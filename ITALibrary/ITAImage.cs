using System.Drawing;

namespace ITALibrary
{
    public class ITAImage
    {
        public string ImagePath { get; }
        public int OriginalHeight { get; }
        public int OriginalWidth { get; }

        public ColorCharacters colorCharacters = new ColorCharacters();

        private Bitmap Image { get; set; }

        public ITAImage(string imagePath)
        {
            this.ImagePath = imagePath;
            
            this.Image = ConvertToBitmap.Convert(imagePath);
            this.OriginalHeight = Image.Height;
            this.OriginalWidth = Image.Width;
            this.colorCharacters.WhiteColorCharacter = ' ';
            this.colorCharacters.BlackColorCharacter = '#';
            this.colorCharacters.RGBBelowHundred = '@';
            this.colorCharacters.RGBBelowHundredAndFifty = 'g';
            this.colorCharacters.RGBBelowTwoHundred = '$';
            this.colorCharacters.RGBBelowTwoHundredAndFifty = ':';
            this.colorCharacters.OtherColorsCharacter = '.';
        }

        public void ResizeImage(int width, int height)
        {
            using (Image)
            {
                Image = (Bitmap)ImageResize.ResizeImage(Image, new Size(width, height));
            }
        }

        public override string ToString()
        {
            return ConvertToASCII.Convert(Image, colorCharacters.WhiteColorCharacter, colorCharacters.BlackColorCharacter, colorCharacters.RGBBelowHundred,
                colorCharacters.RGBBelowHundredAndFifty, colorCharacters.RGBBelowTwoHundred, 
                colorCharacters.RGBBelowTwoHundredAndFifty, colorCharacters.OtherColorsCharacter);
        }

        public void SaveToFile(string fileName)
        {
            SaveASCII.SaveFile(fileName, this.ToString());
        }
    }
}
