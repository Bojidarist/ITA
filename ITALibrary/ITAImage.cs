using System.Text;
using System.Drawing;

namespace ITALibrary
{
    public class ITAImage
    {
        public string ImagePath { get; set; }
        public int Height { get; }
        public int Width { get; }
        public char WhiteColorCharacter { get; set; }
        public char OtherColorsCharacter { get; set; }

        private Bitmap Image { get; set; }

        public ITAImage(string imagePath, char whiteColorCharacter = ' ', char otherColorsCharacter = '#')
        {
            this.ImagePath = imagePath;

            Bitmap bitmap = ConvertToBitmap.Convert(imagePath);
            this.Image = bitmap;
            this.Height = bitmap.Height;
            this.Width = bitmap.Width;
            this.WhiteColorCharacter = whiteColorCharacter;
            this.OtherColorsCharacter = otherColorsCharacter;
        }


        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            for (int y = 0; y < Height; y++)
            {
                for (int x = 0; x < Width; x++)
                {
                    Color pixel = Image.GetPixel(x, y);

                    if (pixel == Color.FromArgb(255, 255, 255, 255) || pixel == Color.FromArgb(0, 255, 255, 255))
                    {
                        sb.Append(WhiteColorCharacter);
                    }
                    else
                    {
                        sb.Append(OtherColorsCharacter);
                    }
                }
                sb.Append("\n");
            }
            return sb.ToString();
        }
    }
}
