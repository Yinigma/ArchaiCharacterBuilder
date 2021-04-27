namespace Domain.Core.ValueObjects
{
    public class Sprite
    {
        string Path { get; }

        public Sprite(string path)
        {
            Path = path;
        }

        public bool Equals(Sprite other)
        {
            return Path.Equals(other.Path);
        }
        //Save this for Character Creator Domain
        /*public long Id { get; }
        public Color[,] SpriteData { get; set; }

        public int Width { get; private set; }

        public int Height { get; private set; }

        public Sprite ConvertToHurtbox()
        {
            Color[,] hurtbox = new Color[Width, Height];
            for(int r = 0; r < Width; r++)
            {
                for(int c = 0; c < Height; c++)
                {
                    hurtbox[r,c] = new Color()
                }
            }
        }

        public void LoadSpriteData(Color[] colors, int width, int height)
        {
            Width = width;
            Height = height;
        }

        public Sprite(long id)
        {
            Id = id;
        }*/
    }
}
