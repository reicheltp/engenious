﻿using System.ComponentModel;
using System.Windows.Forms;
using ContentTool.Controls;

namespace ContentTool.Forms
{
    partial class MainShell
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip_main = new System.Windows.Forms.MenuStrip();
            this.projectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.saveProjectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveProjectAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.closeProjectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.undoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.redoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripSeparator();
            this.addToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newItemToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.existingItemToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.existingFolderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newFolderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.renameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.removeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.buildToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.buildToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.cleanToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rebuildToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem5 = new System.Windows.Forms.ToolStripSeparator();
            this.alwaysShowLogToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.integrateProjectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripSeparator();
            this.aboutToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip_main = new System.Windows.Forms.ToolStrip();
            this.toolStripButton_new = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton_open = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton_save = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton_newItemAdd = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton_existingItemAdd = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton_newFolderAdd = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton_existingFolderAdd = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton_build = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton_clean = new System.Windows.Forms.ToolStripButton();
            this.splitContainer_main = new System.Windows.Forms.SplitContainer();
            this.splitContainer_left = new System.Windows.Forms.SplitContainer();
            this.projectTreeView = new ContentTool.Controls.ProjectTreeView();
            this.itemPropertyView = new ContentTool.Controls.ItemPropertyView();
            this.splitContainer_right = new System.Windows.Forms.SplitContainer();
            this.consoleView = new ContentTool.Controls.ConsoleView();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripProgressBar = new System.Windows.Forms.ToolStripProgressBar();
            this.main_panel = new System.Windows.Forms.Panel();
            this.menuStrip_main.SuspendLayout();
            this.toolStrip_main.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer_main)).BeginInit();
            this.splitContainer_main.Panel1.SuspendLayout();
            this.splitContainer_main.Panel2.SuspendLayout();
            this.splitContainer_main.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer_left)).BeginInit();
            this.splitContainer_left.Panel1.SuspendLayout();
            this.splitContainer_left.Panel2.SuspendLayout();
            this.splitContainer_left.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer_right)).BeginInit();
            this.splitContainer_right.Panel2.SuspendLayout();
            this.splitContainer_right.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.main_panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip_main
            // 
            this.menuStrip_main.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.projectToolStripMenuItem,
            this.editToolStripMenuItem,
            this.buildToolStripMenuItem,
            this.integrateProjectToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.menuStrip_main.Location = new System.Drawing.Point(0, 0);
            this.menuStrip_main.Name = "menuStrip_main";
            this.menuStrip_main.Size = new System.Drawing.Size(978, 24);
            this.menuStrip_main.TabIndex = 0;
            this.menuStrip_main.Text = "menuStrip1";
            // 
            // projectToolStripMenuItem
            // 
            this.projectToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.openToolStripMenuItem,
            this.toolStripMenuItem1,
            this.saveProjectToolStripMenuItem,
            this.saveProjectAsToolStripMenuItem,
            this.toolStripMenuItem2,
            this.closeProjectToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.projectToolStripMenuItem.Name = "projectToolStripMenuItem";
            this.projectToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.projectToolStripMenuItem.Text = "&File";
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.newToolStripMenuItem.Size = new System.Drawing.Size(277, 22);
            this.newToolStripMenuItem.Text = "&New Project";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.openToolStripMenuItem.Size = new System.Drawing.Size(277, 22);
            this.openToolStripMenuItem.Text = "&Open Project";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(274, 6);
            // 
            // saveProjectToolStripMenuItem
            // 
            this.saveProjectToolStripMenuItem.Name = "saveProjectToolStripMenuItem";
            this.saveProjectToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.saveProjectToolStripMenuItem.Size = new System.Drawing.Size(277, 22);
            this.saveProjectToolStripMenuItem.Text = "&Save Project";
            this.saveProjectToolStripMenuItem.Enabled = false;
            // 
            // saveProjectAsToolStripMenuItem
            // 
            this.saveProjectAsToolStripMenuItem.Name = "saveProjectAsToolStripMenuItem";
            this.saveProjectAsToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.S)));
            this.saveProjectAsToolStripMenuItem.Size = new System.Drawing.Size(277, 22);
            this.saveProjectAsToolStripMenuItem.Text = "Save Project &as";
            this.saveProjectAsToolStripMenuItem.Enabled = false;
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(274, 6);
            // 
            // closeProjectToolStripMenuItem
            // 
            this.closeProjectToolStripMenuItem.Name = "closeProjectToolStripMenuItem";
            this.closeProjectToolStripMenuItem.Size = new System.Drawing.Size(277, 22);
            this.closeProjectToolStripMenuItem.Text = "&Close Project";
            this.closeProjectToolStripMenuItem.Enabled = false;
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(277, 22);
            this.exitToolStripMenuItem.Text = "E&xit";
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.undoToolStripMenuItem,
            this.redoToolStripMenuItem,
            this.toolStripMenuItem3,
            this.addToolStripMenuItem,
            this.renameToolStripMenuItem,
            this.removeToolStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.editToolStripMenuItem.Text = "&Edit";
            this.editToolStripMenuItem.Enabled = false;
            // 
            // undoToolStripMenuItem
            // 
            this.undoToolStripMenuItem.Enabled = false;
            this.undoToolStripMenuItem.Name = "undoToolStripMenuItem";
            this.undoToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Z)));
            this.undoToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.undoToolStripMenuItem.Text = "&Undo";
            // 
            // redoToolStripMenuItem
            // 
            this.redoToolStripMenuItem.Enabled = false;
            this.redoToolStripMenuItem.Name = "redoToolStripMenuItem";
            this.redoToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Y)));
            this.redoToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.redoToolStripMenuItem.Text = "&Redo";
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(143, 6);
            // 
            // addToolStripMenuItem
            // 
            this.addToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newItemToolStripMenuItem,
            this.existingItemToolStripMenuItem,
            this.existingFolderToolStripMenuItem,
            this.newFolderToolStripMenuItem});
            this.addToolStripMenuItem.Name = "addToolStripMenuItem";
            this.addToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.addToolStripMenuItem.Text = "Add";
            // 
            // newItemToolStripMenuItem
            // 
            this.newItemToolStripMenuItem.Name = "newItemToolStripMenuItem";
            this.newItemToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.newItemToolStripMenuItem.Text = "New Item";
            // 
            // existingItemToolStripMenuItem
            // 
            this.existingItemToolStripMenuItem.Name = "existingItemToolStripMenuItem";
            this.existingItemToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.existingItemToolStripMenuItem.Text = "Existing Item";
            // 
            // existingFolderToolStripMenuItem
            // 
            this.existingFolderToolStripMenuItem.Name = "existingFolderToolStripMenuItem";
            this.existingFolderToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.existingFolderToolStripMenuItem.Text = "Existing Folder";
            // 
            // newFolderToolStripMenuItem
            // 
            this.newFolderToolStripMenuItem.Name = "newFolderToolStripMenuItem";
            this.newFolderToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.newFolderToolStripMenuItem.Text = "New Folder";
            // 
            // renameToolStripMenuItem
            // 
            this.renameToolStripMenuItem.Name = "renameToolStripMenuItem";
            this.renameToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.renameToolStripMenuItem.Text = "Rename";
            this.renameToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F2;
            // 
            // removeToolStripMenuItem
            // 
            this.removeToolStripMenuItem.Name = "removeToolStripMenuItem";
            this.removeToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.removeToolStripMenuItem.Text = "Remove";
            this.removeToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.Delete;
            // 
            // buildToolStripMenuItem
            // 
            this.buildToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.buildToolStripMenuItem1,
            this.cleanToolStripMenuItem,
            this.rebuildToolStripMenuItem,
            this.toolStripMenuItem5,
            this.alwaysShowLogToolStripMenuItem});
            this.buildToolStripMenuItem.Name = "buildToolStripMenuItem";
            this.buildToolStripMenuItem.Size = new System.Drawing.Size(46, 20);
            this.buildToolStripMenuItem.Text = "Build";
            this.buildToolStripMenuItem.Enabled = false;
            // 
            // buildToolStripMenuItem1
            // 
            this.buildToolStripMenuItem1.Name = "buildToolStripMenuItem1";
            this.buildToolStripMenuItem1.Size = new System.Drawing.Size(165, 22);
            this.buildToolStripMenuItem1.Text = "Build";
            // 
            // cleanToolStripMenuItem
            // 
            this.cleanToolStripMenuItem.Name = "cleanToolStripMenuItem";
            this.cleanToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.cleanToolStripMenuItem.Text = "Clean";
            // 
            // rebuildToolStripMenuItem
            // 
            this.rebuildToolStripMenuItem.Name = "rebuildToolStripMenuItem";
            this.rebuildToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.rebuildToolStripMenuItem.Text = "Rebuild";
            // 
            // toolStripMenuItem5
            // 
            this.toolStripMenuItem5.Name = "toolStripMenuItem5";
            this.toolStripMenuItem5.Size = new System.Drawing.Size(162, 6);
            // 
            // alwaysShowLogToolStripMenuItem
            // 
            this.alwaysShowLogToolStripMenuItem.CheckOnClick = true;
            this.alwaysShowLogToolStripMenuItem.Name = "alwaysShowLogToolStripMenuItem";
            this.alwaysShowLogToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.alwaysShowLogToolStripMenuItem.Text = "Always show Log";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.helpToolStripMenuItem,
            this.toolStripMenuItem4,
            this.aboutToolStripMenuItem1});
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.aboutToolStripMenuItem.Text = "About";
            
            // 
            // integrateProjectToolStripMenuItem
            // 
            this.integrateProjectToolStripMenuItem.Name = "integrateProjectToolStripMenuItem";
            this.integrateProjectToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.integrateProjectToolStripMenuItem.Text = "Integrate in C#";
            this.integrateProjectToolStripMenuItem.Enabled = false;
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.Enabled = false;
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // toolStripMenuItem4
            // 
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            this.toolStripMenuItem4.Size = new System.Drawing.Size(104, 6);
            // 
            // aboutToolStripMenuItem1
            // 
            this.aboutToolStripMenuItem1.Name = "aboutToolStripMenuItem1";
            this.aboutToolStripMenuItem1.Size = new System.Drawing.Size(107, 22);
            this.aboutToolStripMenuItem1.Text = "About";
            // 
            // toolStrip_main
            // 
            this.toolStrip_main.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip_main.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton_new,
            this.toolStripButton_open,
            this.toolStripButton_save,
            this.toolStripSeparator1,
            this.toolStripButton_newItemAdd,
            this.toolStripButton_existingItemAdd,
            this.toolStripButton_newFolderAdd,
            this.toolStripButton_existingFolderAdd,
            this.toolStripSeparator2,
            this.toolStripButton_build,
            this.toolStripButton_clean});
            this.toolStrip_main.Location = new System.Drawing.Point(0, 24);
            this.toolStrip_main.Name = "toolStrip_main";
            this.toolStrip_main.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.toolStrip_main.Size = new System.Drawing.Size(978, 27);
            this.toolStrip_main.TabIndex = 1;
            this.toolStrip_main.Text = "toolStrip1";
            // 
            // toolStripButton_new
            // 
            this.toolStripButton_new.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton_new.Image = global::ContentTool.Properties.Resources.Objects;
            this.toolStripButton_new.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton_new.Name = "toolStripButton_new";
            this.toolStripButton_new.Size = new System.Drawing.Size(24, 24);
            this.toolStripButton_new.Text = "New";
            // 
            // toolStripButton_open
            // 
            this.toolStripButton_open.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton_open.Image = global::ContentTool.Properties.Resources.Open_folder;
            this.toolStripButton_open.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton_open.Name = "toolStripButton_open";
            this.toolStripButton_open.Size = new System.Drawing.Size(24, 24);
            this.toolStripButton_open.Text = "Open";
            // 
            // toolStripButton_save
            // 
            this.toolStripButton_save.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton_save.Image = global::ContentTool.Properties.Resources.Save;
            this.toolStripButton_save.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton_save.Name = "toolStripButton_save";
            this.toolStripButton_save.Size = new System.Drawing.Size(24, 24);
            this.toolStripButton_save.Text = "Save";
            this.toolStripButton_save.Enabled = false;
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 27);
            // 
            // toolStripButton_newItemAdd
            // 
            this.toolStripButton_newItemAdd.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton_newItemAdd.Image = global::ContentTool.Properties.Resources.New_file;
            this.toolStripButton_newItemAdd.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton_newItemAdd.Name = "toolStripButton_newItemAdd";
            this.toolStripButton_newItemAdd.Size = new System.Drawing.Size(24, 24);
            this.toolStripButton_newItemAdd.Text = "Add new Item";
            this.toolStripButton_newItemAdd.Enabled = false;
            // 
            // toolStripButton_existingItemAdd
            // 
            this.toolStripButton_existingItemAdd.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton_existingItemAdd.Image = global::ContentTool.Properties.Resources.Import;
            this.toolStripButton_existingItemAdd.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton_existingItemAdd.Name = "toolStripButton_existingItemAdd";
            this.toolStripButton_existingItemAdd.Size = new System.Drawing.Size(24, 24);
            this.toolStripButton_existingItemAdd.Text = "Add existing Item";
            this.toolStripButton_existingItemAdd.Enabled = false;
            // 
            // toolStripButton_newFolderAdd
            // 
            this.toolStripButton_newFolderAdd.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton_newFolderAdd.Image = global::ContentTool.Properties.Resources.Add_folder;
            this.toolStripButton_newFolderAdd.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton_newFolderAdd.Name = "toolStripButton_newFolderAdd";
            this.toolStripButton_newFolderAdd.Size = new System.Drawing.Size(24, 24);
            this.toolStripButton_newFolderAdd.Text = "Add new Folder";
            this.toolStripButton_newFolderAdd.Enabled = false;
            // 
            // toolStripButton_existingFolderAdd
            // 
            this.toolStripButton_existingFolderAdd.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton_existingFolderAdd.Image = global::ContentTool.Properties.Resources.Open_folder;
            this.toolStripButton_existingFolderAdd.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton_existingFolderAdd.Name = "toolStripButton_existingFolderAdd";
            this.toolStripButton_existingFolderAdd.Size = new System.Drawing.Size(24, 24);
            this.toolStripButton_existingFolderAdd.Text = "Add existing Folder";
            this.toolStripButton_existingFolderAdd.Enabled = false;
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 27);
            // 
            // toolStripButton_build
            // 
            this.toolStripButton_build.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton_build.Image = global::ContentTool.Properties.Resources.Equipment;
            this.toolStripButton_build.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton_build.Name = "toolStripButton_build";
            this.toolStripButton_build.Size = new System.Drawing.Size(24, 24);
            this.toolStripButton_build.Text = "Build";
            this.toolStripButton_build.Enabled = false;
            // 
            // toolStripButton_clean
            // 
            this.toolStripButton_clean.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton_clean.Image = global::ContentTool.Properties.Resources.Eraser;
            this.toolStripButton_clean.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton_clean.Name = "toolStripButton_clean";
            this.toolStripButton_clean.Size = new System.Drawing.Size(24, 24);
            this.toolStripButton_clean.Text = "Clean";
            this.toolStripButton_clean.Enabled = false;
            // 
            // splitContainer_main
            // 
            this.splitContainer_main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer_main.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer_main.Location = new System.Drawing.Point(0, 0);
            this.splitContainer_main.Name = "splitContainer_main";
            // 
            // splitContainer_main.Panel1
            // 
            this.splitContainer_main.Panel1.Controls.Add(this.splitContainer_left);
            // 
            // splitContainer_main.Panel2
            // 
            this.splitContainer_main.Panel2.Controls.Add(this.splitContainer_right);
            this.splitContainer_main.Size = new System.Drawing.Size(978, 521);
            this.splitContainer_main.SplitterDistance = 213;
            this.splitContainer_main.TabIndex = 2;
            // 
            // splitContainer_left
            // 
            this.splitContainer_left.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer_left.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
            this.splitContainer_left.Location = new System.Drawing.Point(0, 0);
            this.splitContainer_left.Name = "splitContainer_left";
            this.splitContainer_left.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer_left.Panel1
            // 
            this.splitContainer_left.Panel1.Controls.Add(this.projectTreeView);
            // 
            // splitContainer_left.Panel2
            // 
            this.splitContainer_left.Panel2.Controls.Add(this.itemPropertyView);
            this.splitContainer_left.Size = new System.Drawing.Size(213, 521);
            this.splitContainer_left.SplitterDistance = 283;
            this.splitContainer_left.TabIndex = 0;
            // 
            // projectTreeView
            // 
            this.projectTreeView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.projectTreeView.Location = new System.Drawing.Point(0, 0);
            this.projectTreeView.Name = "projectTreeView";
            this.projectTreeView.Project = null;
            this.projectTreeView.Size = new System.Drawing.Size(213, 283);
            this.projectTreeView.TabIndex = 0;
            // 
            // itemPropertyView
            // 
            this.itemPropertyView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.itemPropertyView.Location = new System.Drawing.Point(0, 0);
            this.itemPropertyView.Name = "itemPropertyView";
            this.itemPropertyView.Size = new System.Drawing.Size(213, 234);
            this.itemPropertyView.TabIndex = 0;
            // 
            // splitContainer_right
            // 
            this.splitContainer_right.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer_right.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
            this.splitContainer_right.Location = new System.Drawing.Point(0, 0);
            this.splitContainer_right.Name = "splitContainer_right";
            this.splitContainer_right.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer_right.Panel1
            // 
            this.splitContainer_right.Panel1.AutoScroll = true;
            // 
            // splitContainer_right.Panel2
            // 
            this.splitContainer_right.Panel2.Controls.Add(this.consoleView);
            this.splitContainer_right.Panel2Collapsed = true;
            this.splitContainer_right.Size = new System.Drawing.Size(761, 521);
            this.splitContainer_right.SplitterDistance = 374;
            this.splitContainer_right.TabIndex = 0;
            // 
            // consoleView
            // 
            this.consoleView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.consoleView.Location = new System.Drawing.Point(0, 0);
            this.consoleView.Name = "consoleView";
            this.consoleView.Size = new System.Drawing.Size(150, 46);
            this.consoleView.TabIndex = 0;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripProgressBar});
            this.statusStrip1.Location = new System.Drawing.Point(0, 572);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(978, 22);
            this.statusStrip1.TabIndex = 3;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripProgressBar
            // 
            this.toolStripProgressBar.Name = "toolStripProgressBar";
            this.toolStripProgressBar.Size = new System.Drawing.Size(100, 16);
            // 
            // main_panel
            // 
            this.main_panel.Controls.Add(this.splitContainer_main);
            this.main_panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.main_panel.Location = new System.Drawing.Point(0, 51);
            this.main_panel.Name = "main_panel";
            this.main_panel.Size = new System.Drawing.Size(978, 521);
            this.main_panel.TabIndex = 4;
            // 
            // MainShell
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(978, 594);
            this.Controls.Add(this.main_panel);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.toolStrip_main);
            this.Controls.Add(this.menuStrip_main);
            this.MainMenuStrip = this.menuStrip_main;
            this.Name = "MainShell";
            this.Text = "MainShell";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainShell_FormClosing);
            this.menuStrip_main.ResumeLayout(false);
            this.menuStrip_main.PerformLayout();
            this.toolStrip_main.ResumeLayout(false);
            this.toolStrip_main.PerformLayout();
            this.splitContainer_main.Panel1.ResumeLayout(false);
            this.splitContainer_main.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer_main)).EndInit();
            this.splitContainer_main.ResumeLayout(false);
            this.splitContainer_left.Panel1.ResumeLayout(false);
            this.splitContainer_left.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer_left)).EndInit();
            this.splitContainer_left.ResumeLayout(false);
            this.splitContainer_right.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer_right)).EndInit();
            this.splitContainer_right.ResumeLayout(false);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.main_panel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MenuStrip menuStrip_main;
        private ToolStripMenuItem projectToolStripMenuItem;
        private ToolStripMenuItem editToolStripMenuItem;
        private ToolStripMenuItem buildToolStripMenuItem;
        private ToolStripMenuItem integrateProjectToolStripMenuItem;
        private ToolStripMenuItem aboutToolStripMenuItem;
        private ToolStrip toolStrip_main;
        private SplitContainer splitContainer_main;
        private SplitContainer splitContainer_left;
        private SplitContainer splitContainer_right;
        private ProjectTreeView projectTreeView;
        private ItemPropertyView itemPropertyView;
        private ConsoleView consoleView;
        private ToolStripMenuItem newToolStripMenuItem;
        private ToolStripMenuItem openToolStripMenuItem;
        private ToolStripSeparator toolStripMenuItem1;
        private ToolStripMenuItem saveProjectToolStripMenuItem;
        private ToolStripMenuItem saveProjectAsToolStripMenuItem;
        private ToolStripSeparator toolStripMenuItem2;
        private ToolStripMenuItem closeProjectToolStripMenuItem;
        private ToolStripMenuItem exitToolStripMenuItem;
        private ToolStripMenuItem undoToolStripMenuItem;
        private ToolStripMenuItem redoToolStripMenuItem;
        private ToolStripSeparator toolStripMenuItem3;
        private ToolStripMenuItem addToolStripMenuItem;
        private ToolStripMenuItem existingItemToolStripMenuItem;
        private ToolStripMenuItem existingFolderToolStripMenuItem;
        private ToolStripMenuItem newFolderToolStripMenuItem;
        private ToolStripMenuItem renameToolStripMenuItem;
        private ToolStripMenuItem removeToolStripMenuItem;
        private ToolStripMenuItem buildToolStripMenuItem1;
        private ToolStripMenuItem cleanToolStripMenuItem;
        private ToolStripMenuItem rebuildToolStripMenuItem;
        private ToolStripMenuItem helpToolStripMenuItem;
        private ToolStripSeparator toolStripMenuItem4;
        private ToolStripMenuItem aboutToolStripMenuItem1;
        private ToolStripButton toolStripButton_new;
        private ToolStripButton toolStripButton_open;
        private ToolStripButton toolStripButton_save;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripButton toolStripButton_build;
        private ToolStripButton toolStripButton_clean;
        private StatusStrip statusStrip1;
        private Panel main_panel;
        private ToolStripSeparator toolStripMenuItem5;
        private ToolStripMenuItem alwaysShowLogToolStripMenuItem;
        private ToolStripProgressBar toolStripProgressBar;
        private ToolStripButton toolStripButton_newItemAdd;
        private ToolStripButton toolStripButton_existingItemAdd;
        private ToolStripButton toolStripButton_newFolderAdd;
        private ToolStripButton toolStripButton_existingFolderAdd;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripMenuItem newItemToolStripMenuItem;
    }
}