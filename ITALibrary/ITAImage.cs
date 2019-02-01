using System.Drawing;

namespace ITALibrary
{
    public class ITAImage
    {
        public string ImagePath { get; }
        public int OriginalHeight { get; }
        public int OriginalWidth { get; }
        public char WhiteColorCharacter { get; set; }
        public char BlackColorCharacter { get; set; }
        public char RGBBelowHundred { get; set; }
        public char RGBBelowHundredAndFifty { get; set; }
        public char RGBBelowTwoHundred { get; set; }
        public char RGBBelowTwoHundredAndFifty { get; set; }
        public char OtherColorsCharacter { get; set; }

        private Bitmap Image { get; set; }

        public ITAImage(string imagePath, char whiteColorCharacter = ' ', char blackColorCharacter = '#', char rgbBelowHundred = '@',
            char rgbBelowHundredAndFifty = 'g', char rgbBelowTwoHundred = '$', char rgbBelowTwoHundredAndFifty = ':', char otherColorsCharacter = '.')
        {
            this.ImagePath = imagePath;
            
            this.Image = ConvertToBitmap.Convert(imagePath);
            this.OriginalHeight = Image.Height;
            this.OriginalWidth = Image.Width;
            this.WhiteColorCharacter = whiteColorCharacter;
            this.BlackColorCharacter = blackColorCharacter;
            this.RGBBelowHundred = rgbBelowHundred;
            this.RGBBelowHundredAndFifty = rgbBelowHundredAndFifty;
            this.RGBBelowTwoHundred = rgbBelowTwoHundred;
            this.RGBBelowTwoHundredAndFifty = rgbBelowTwoHundredAndFifty;
            this.OtherColorsCharacter = otherColorsCharacter;
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
            return ConvertToASCII.Convert(Image, WhiteColorCharacter, BlackColorCharacter, RGBBelowHundred,
                RGBBelowHundredAndFifty, RGBBelowTwoHundred, RGBBelowTwoHundredAndFifty, OtherColorsCharacter);
        }
    }
}
