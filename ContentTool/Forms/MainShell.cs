﻿using System;
using System.Collections.Specialized;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Threading;
using System.Windows.Forms;
using ContentTool.Forms.Dialogs;
using ContentTool.Models;
using ContentTool.Viewer;
using Timer = System.Windows.Forms.Timer;

namespace ContentTool.Forms
{
    public partial class MainShell : Form, IMainShell
    {
        public ContentProject Project
        {
            get => _project;
            set
            {
                if (_project == value)
                    return;

                if (_project != null)
                {
                    _project.History.HistoryChanged -= HistoryOnHistoryChanged;
                    _project.CollectionChanged -= ProjectOnCollectionChanged;
                }

                _project = value;
                if (_project != null)
                {
                    _project.History.HistoryChanged += HistoryOnHistoryChanged;
                    _project.CollectionChanged += ProjectOnCollectionChanged;
                }
                projectTreeView.Project = Project;

                buildToolStripMenuItem.Enabled = editToolStripMenuItem.Enabled =
                    saveProjectToolStripMenuItem.Enabled = saveProjectAsToolStripMenuItem.Enabled =
                        closeProjectToolStripMenuItem.Enabled = editToolStripMenuItem.Enabled =
                            buildToolStripMenuItem.Enabled = toolStripButton_save.Enabled =
                                toolStripButton_newItemAdd.Enabled = toolStripButton_existingItemAdd.Enabled =
                                    toolStripButton_newFolderAdd.Enabled = toolStripButton_existingFolderAdd.Enabled =
                                        toolStripButton_build.Enabled = toolStripButton_clean.Enabled =
                                            integrateProjectToolStripMenuItem.Enabled = value != null;
            }
        }


        private void HistoryOnHistoryChanged(object sender, EventArgs eventArgs)
        {
            if (IsRenderingSuspended)
                return;
            if (InvokeRequired)
            {
                Invoke(new MethodInvoker(() => HistoryOnHistoryChanged(sender, eventArgs)));
                return;
            }
            undoToolStripMenuItem.Enabled = Project?.History?.CanUndo ?? false;
            redoToolStripMenuItem.Enabled = Project?.History?.CanRedo ?? false;
            itemPropertyView.Refresh();
        }

        private void ProjectOnCollectionChanged(object sender,
            NotifyCollectionChangedEventArgs notifyCollectionChangedEventArgs)
        {
        }

        private ContentProject _project;
        public IViewer CurrentViewer { get; private set; }

        private LoadingDialog _loadingDialog = new LoadingDialog();
        private readonly Timer _loadingTimer = new Timer();

        public MainShell()
        {
            InitializeComponent();
        }

        public event EventHandler OnShellLoad;

        protected override void OnLoad(EventArgs ea)
        {
            base.OnLoad(ea);

            ShowItemButtons(false);

            projectTreeView.Shell = this;
            projectTreeView.SelectedContentItemChanged += ProjectTreeView_SelectedContentItemChanged;
            projectTreeView.AddExistingItemClick +=
                f => AddExistingItemClick?.Invoke(f);
            projectTreeView.AddExistingFolderClick +=
                f => AddExistingFolderClick?.Invoke(f);
            projectTreeView.AddNewFolderClick += f => AddNewFolderClick?.Invoke(f);
            projectTreeView.BuildItemClick += i => BuildItemClick?.Invoke(i);
            projectTreeView.RemoveItemClick += i => { RemoveItemClick?.Invoke(i); };
            projectTreeView.ShowInExplorerItemClick += i => ShowInExplorerItemClick?.Invoke(i);

            newToolStripMenuItem.Click += (s, e) => NewProjectClick?.Invoke(this, EventArgs.Empty);
            openToolStripMenuItem.Click += (s, e) => OpenProjectClick?.Invoke(this, EventArgs.Empty);
            closeProjectToolStripMenuItem.Click += (s, e) => CloseProjectClick?.Invoke(Project);
            saveProjectToolStripMenuItem.Click += (s, e) => SaveProjectClick?.Invoke(Project);
            saveProjectAsToolStripMenuItem.Click += (s, e) => SaveProjectAsClick?.Invoke(Project);

            exitToolStripMenuItem.Click += (s, e) =>
            {
                CloseProjectClick?.Invoke(Project);
                Application.Exit();
            };

            toolStripButton_new.Click += (s, e) => NewProjectClick?.Invoke(this, EventArgs.Empty);
            toolStripButton_open.Click += (s, e) => OpenProjectClick?.Invoke(this, EventArgs.Empty);
            toolStripButton_save.Click += (s, e) => SaveProjectClick?.Invoke(Project);

            toolStripButton_build.Click += (s, e) => BuildItemClick?.Invoke(Project);
            toolStripButton_clean.Click += (s, e) => CleanClick?.Invoke(this, EventArgs.Empty);

            buildToolStripMenuItem1.Click += (s, e) => BuildItemClick?.Invoke(Project);
            rebuildToolStripMenuItem.Click += (s, e) => RebuildClick?.Invoke(this, EventArgs.Empty);
            cleanToolStripMenuItem.Click += (s, e) => CleanClick?.Invoke(this, EventArgs.Empty);
            //toolStripButton_clean.Click += (s,e) => Clea

            toolStripButton_existingItemAdd.Click +=
                (s, e) => AddExistingItemClick?.Invoke(projectTreeView.SelectedFolder);
            toolStripButton_existingFolderAdd.Click +=
                (s, e) => AddExistingFolderClick?.Invoke(projectTreeView.SelectedFolder);
            toolStripButton_newFolderAdd.Click += (s, e) => AddNewFolderClick?.Invoke(projectTreeView.SelectedFolder);
            //toolStripButton_newItemAdd.Click += (s, e) => AddNewItemClick?.Invoke(projectTreeView.SelectedFolder, baaah);

            integrateProjectToolStripMenuItem.Click += (s, e) => IntegrateCSClick?.Invoke(this, EventArgs.Empty);
            aboutToolStripMenuItem1.Click += (s, e) => { OnAboutClick?.Invoke(this, EventArgs.Empty); };
            helpToolStripMenuItem.Click += (s, e) => OnHelpClick?.Invoke(this, EventArgs.Empty);

            existingItemToolStripMenuItem.Click +=
                (s, e) => AddExistingItemClick?.Invoke(projectTreeView.SelectedFolder);
            existingFolderToolStripMenuItem.Click +=
                (s, e) => AddExistingFolderClick?.Invoke(projectTreeView.SelectedFolder);
            newFolderToolStripMenuItem.Click += (s, e) => AddNewFolderClick?.Invoke(projectTreeView.SelectedFolder);
            removeToolStripMenuItem.Click += (s, e) => RemoveItemClick?.Invoke(projectTreeView.SelectedItem);
            renameToolStripMenuItem.Click += (s, e) => RenameItemClick?.Invoke(projectTreeView.SelectedItem);

            undoToolStripMenuItem.Click += (s, e) => UndoClick?.Invoke(this, EventArgs.Empty);
            redoToolStripMenuItem.Click += (s, e) => RedoClick?.Invoke(this, EventArgs.Empty);
            editToolStripMenuItem.DropDownOpening += EditToolStripMenuItemOnDropDownOpening;

            projectTreeView.SelectedContentItemChanged += i => OnItemSelect?.Invoke(i);
            projectTreeView.Refreshed += (s, e) => ViewReloaded?.Invoke(this, e);

            alwaysShowLogToolStripMenuItem.CheckedChanged += (s, e) =>
                splitContainer_right.Panel2Collapsed = !alwaysShowLogToolStripMenuItem.Checked;
        }


        public void ShowItemButtons(bool value)
        {
            removeToolStripMenuItem.Enabled = value;
            renameToolStripMenuItem.Enabled = value;
        }

        protected override void OnShown(EventArgs e)
        {
            base.OnShown(e);
            OnShellLoad?.Invoke(this, EventArgs.Empty);
        }

        private void EditToolStripMenuItemOnDropDownOpening(object sender, EventArgs eventArgs)
        {
            undoToolStripMenuItem.Enabled = Project?.History?.CanUndo ?? false;
            redoToolStripMenuItem.Enabled = Project?.History?.CanRedo ?? false;
        }

        private void ProjectTreeView_SelectedContentItemChanged(ContentItem newItem)
        {
            ShowItemButtons(!(newItem == null || newItem is ContentProject));
            itemPropertyView.SelectItem(newItem);
        }


        public bool ShowCloseWithoutSavingConfirmation()
        {
            var result =
                MessageBox.Show(
                    $"There are unsaved changes. {Environment.NewLine} Do you want to save the project before closing it?",
                    "Unsaved changes", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);
            if (result == DialogResult.Cancel)
                return false;
            if (result != DialogResult.Yes) return true;
            if (CurrentViewer != null && CurrentViewer.UnsavedChanges)
                CurrentViewer.Save();
            if (_project.HasUnsavedChanges)
                SaveProjectClick?.Invoke(Project);

            return true;
        }

        public string ShowOpenDialog()
        {
            var ofd = new OpenFileDialog();
            ofd.Filter = "Engenious Content Project(.ecp)|*.ecp";
            return ofd.ShowDialog() == DialogResult.OK ? ofd.FileName : null;
        }

        public string ShowSaveAsDialog()
        {
            using (var sfd = new SaveFileDialog())
            {
                sfd.Filter = "Engenious Content Project(.ecp)|*.ecp";
                sfd.FileName = Project?.ContentProjectPath ?? "Content.ecp";
                sfd.OverwritePrompt = true;
                return sfd.ShowDialog() == DialogResult.OK ? sfd.FileName : null;
            }
        }

        public string ShowIntegrateDialog()
        {
            using (var ofd = new OpenFileDialog())
            {
                ofd.Title = "C# Project to add Content Project";
                ofd.Filter = "C# Project(.csproj)|*.csproj";
                string path = Path.GetDirectoryName(Project?.ContentProjectPath ?? "") ?? "";
                ofd.FileName = Directory.GetFiles(path,"*.csproj")?.FirstOrDefault();
                return ofd.ShowDialog() == DialogResult.OK ? ofd.FileName : null;
            }
        }

        public void WriteLog(string text, Color color = default(Color)) => consoleView.Write(text, color);
        public void WriteLineLog(string text, Color color = default(Color)) => consoleView.WriteLine(text, color);
        public void ClearLog() => consoleView.Clear();

        public void ShowLoading(string title = "Please wait...")
        {
            toolStripProgressBar.Style = ProgressBarStyle.Marquee;
            toolStripProgressBar.Visible = true;

            _loadingDialog = new LoadingDialog();
            _loadingDialog.Title = title;
            _loadingTimer.Tick += (s, e) =>
            {
                _loadingTimer.Stop();
                if (_loadingDialog.Visible) return;
                Enabled = false;
                _loadingDialog.Show(this);
            };
            _loadingTimer.Interval = 400;
            _loadingTimer.Start();
        }

        public void HideLoading()
        {
            toolStripProgressBar.Visible = false;
            _loadingTimer.Stop();

            _loadingDialog.Close();
            Enabled = true;
            Focus();
        }

        void IMainShell.Invoke(Delegate d) => Invoke(d);
        void IMainShell.BeginInvoke(Delegate d) => BeginInvoke(d);

        public void ShowViewer(IViewer viewer, ContentFile file)
        {
            if (CurrentViewer != null)
            {
                if (CurrentViewer.UnsavedChanges)
                {
                    if (MessageBox.Show(
                            $"This file '{CurrentViewer.ContentFile.Name}' has unsaved changes. Do you want to save them?",
                            "Save changes?", MessageBoxButtons.YesNo,
                            MessageBoxIcon.Warning) == DialogResult.Yes)
                        CurrentViewer.Save();
                    else
                        CurrentViewer.Discard();
                }
                if (CurrentViewer.History != null)
                {
                    _project.History.Remove(CurrentViewer.History);
                }
            }
            splitContainer_right.Panel1.Controls.Clear();

            var viewerControl = viewer?.GetViewerControl(file);
            if (viewerControl == null)
                return;

            CurrentViewer = viewer;

            _project.History.Add(viewer.History);
            viewerControl.Dock = DockStyle.Fill;

            splitContainer_right.Panel1.Controls.Add(viewerControl);
        }

        public void HideViewer() => splitContainer_right.Panel1.Controls.Clear();

        public void ShowLog() => splitContainer_right.Panel2Collapsed = false;

        public void HideLog()
        {
            if (alwaysShowLogToolStripMenuItem.Checked == false)
                splitContainer_right.Panel2Collapsed = true;
        }

        public void ReloadView()
        {
            if (!IsRenderingSuspended)
                projectTreeView.RecalculateView();
        }

        public void WaitProgress(int progress)
        {
            progress = Math.Min(Math.Max(0, progress), 100);
            toolStripProgressBar.Style = ProgressBarStyle.Continuous;

            toolStripProgressBar.Value = progress;

            if (_loadingDialog != null)
                _loadingDialog.Progress = progress;
        }

        public void ShowAbout() => new AboutBox().ShowDialog();

        public bool ShowNotFoundDelete()
            => (MessageBox.Show(
                    "This file could not be found. " + Environment.NewLine +
                    "Do you want to remove it from the Project?", "File not found!", MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning) == DialogResult.Yes);

        public event EventHandler ViewReloaded;

        public event Delegates.ItemActionEventHandler BuildItemClick;
        public event Delegates.ItemActionEventHandler ShowInExplorerItemClick;
        public event Delegates.ItemActionEventHandler RemoveItemClick;

        public event EventHandler NewProjectClick;
        public event EventHandler OpenProjectClick;
        public event Delegates.ItemActionEventHandler CloseProjectClick;
        public event Delegates.ItemActionEventHandler SaveProjectClick;
        public event Delegates.ItemActionEventHandler SaveProjectAsClick;
        public event Delegates.ItemActionEventHandler OnItemSelect;
        public event EventHandler RebuildClick;
        public event EventHandler CleanClick;
        public event Delegates.FolderAddActionEventHandler AddExistingFolderClick;
        public event Delegates.FolderAddActionEventHandler AddNewFolderClick;
        public event Delegates.FolderAddActionEventHandler AddExistingItemClick;
        public event EventHandler IntegrateCSClick;
        public event EventHandler OnAboutClick;
        public event EventHandler OnHelpClick;

        public event EventHandler UndoClick;
        public event EventHandler RedoClick;
        public event Delegates.ItemActionEventHandler RenameItemClick;

        private void MainShell_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (Project == null ||
                !Project.HasUnsavedChanges && !(CurrentViewer != null && CurrentViewer.UnsavedChanges)) return;
            if (!ShowCloseWithoutSavingConfirmation())
                e.Cancel = true;
        }

        public string ShowFolderSelectDialog()
        {
            using (var fbd = new FolderBrowserDialog())
            {
                fbd.SelectedPath = Project.FilePath;
                if (fbd.ShowDialog() == DialogResult.OK)
                    return fbd.SelectedPath;
            }
            return null;
        }

        public string[] ShowFileSelectDialog()
        {
            using (var ofd = new OpenFileDialog())
            {
                ofd.InitialDirectory = Project.FilePath;
                ofd.Multiselect = true;
                if (ofd.ShowDialog() == DialogResult.OK)
                    return ofd.FileNames;
            }
            return null;
        }

        private int _suspendCount;
        public bool IsRenderingSuspended => _suspendCount > 0;

        public void SuspendRendering()
        {
            Interlocked.Increment(ref _suspendCount);
            projectTreeView.SuspendRendering();
        }

        public void ResumeRendering()
        {
            lock (this)
            {
                _suspendCount--;
                if (_suspendCount != 0) return;
                projectTreeView.ResumeRendering();
            }
        }

        public void RenameItem(ContentItem item) => projectTreeView.EditItem(item);
        public void RemoveItem(ContentItem item) => projectTreeView.RemoveItemRequest(projectTreeView.SelectedItem);
    }
}