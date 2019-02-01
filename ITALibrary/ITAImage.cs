using System.Drawing;

namespace ITALibrary
{
    public class ITAImage
    {
        public string ImagePath { get; }
        public int Height { get; }
        public int Width { get; }
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

            Bitmap bitmap = ConvertToBitmap.Convert(imagePath);
            this.Image = bitmap;
            this.Height = bitmap.Height;
            this.Width = bitmap.Width;
            this.WhiteColorCharacter = whiteColorCharacter;
            this.BlackColorCharacter = blackColorCharacter;
            this.RGBBelowHundred = rgbBelowHundred;
            this.RGBBelowHundredAndFifty = rgbBelowHundredAndFifty;
            this.RGBBelowTwoHundred = rgbBelowTwoHundred;
            this.RGBBelowTwoHundredAndFifty = rgbBelowTwoHundredAndFifty;
            this.OtherColorsCharacter = otherColorsCharacter;
        }


        public override string ToString()
        {
            return ConvertToASCII.Convert(Image, WhiteColorCharacter, BlackColorCharacter, RGBBelowHundred,
                RGBBelowHundredAndFifty, RGBBelowTwoHundred, RGBBelowTwoHundredAndFifty, OtherColorsCharacter);
        }
    }
}
