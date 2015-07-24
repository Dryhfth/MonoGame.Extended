using System.Collections.Generic;
using Microsoft.Xna.Framework;

namespace MonoGame.Extended.Content.Pipeline
{
    public class FileFileData
    {
        public FileFileData(string json)
        {
            TextureAssets = new List<string>();
            Json = json;
        }

        public List<string> TextureAssets { get; private set; }
        public string Json { get; private set; }
    }
}