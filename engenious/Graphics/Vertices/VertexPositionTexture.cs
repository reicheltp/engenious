﻿using System.Runtime.InteropServices;

namespace engenious.Graphics
{
	[StructLayout(LayoutKind.Sequential, Pack=1)]
	public struct VertexPositionTexture:IPositionVertex,ITextureCoordinatesVertex
	{
		public static readonly VertexDeclaration VertexDeclaration;

		static VertexPositionTexture()
		{
			VertexElement[] elements = { new VertexElement (0, VertexElementFormat.Vector3, VertexElementUsage.Position, 0), new VertexElement (12, VertexElementFormat.Vector2, VertexElementUsage.TextureCoordinate, 0) };
			var declaration = new VertexDeclaration (elements);
			VertexDeclaration = declaration;
		}
		VertexDeclaration IVertexType.VertexDeclaration => VertexDeclaration;

		public VertexPositionTexture (Vector3 position,Vector2 textureCoord)
		{
			TextureCoordinate = textureCoord;
			Position = position;
		}
			
		public Vector3 Position{ get; set;}
		public Vector2 TextureCoordinate{ get; set;}
	}
}

