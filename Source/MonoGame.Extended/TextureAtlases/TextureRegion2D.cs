﻿using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace MonoGame.Extended.TextureAtlases
{
    public class TextureRegion2D
    {
        public TextureRegion2D(Texture2D texture, int x, int y, int width, int height, Vector2 originNormalized = default(Vector2))
            : this(null, texture, x, y, width, height, originNormalized)
        {
        }

        public TextureRegion2D(Texture2D texture, Rectangle region, Vector2 originNormalized = default(Vector2))
            : this(null, texture, region.X, region.Y, region.Width, region.Height, originNormalized)
        {
        }

        public TextureRegion2D(string name, Texture2D texture, Rectangle region, Vector2 originNormalized = default(Vector2))
            : this(name, texture, region.X, region.Y, region.Width, region.Height, originNormalized)
        {
        }

        public TextureRegion2D(Texture2D texture, Vector2 originNormalized = default(Vector2))
            : this(texture.Name, texture, 0, 0, texture.Width, texture.Height, originNormalized)
        {
        }

        public TextureRegion2D(string name, Texture2D texture, int x, int y, int width, int height, Vector2 originNormalized = default(Vector2))
        {
            if (texture == null) throw new ArgumentNullException(nameof(texture));

            Name = name;
            Texture = texture;
            X = x;
            Y = y;
            Width = width;
            Height = height;
            OriginNormalized = originNormalized;
        }

        public string Name { get; }
        public Texture2D Texture { get; protected set; }
        public int X { get; }
        public int Y { get; }
        public int Width { get; }
        public int Height { get; }
        public Size2 Size => new Size2(Width, Height);
        public object Tag { get; set; }
        public Rectangle Bounds => new Rectangle(X, Y, Width, Height);
        public Vector2 OriginNormalized { get; }

        public override string ToString()
        {
            return $"{Name ?? string.Empty} {Bounds}";
        }
    }
}
