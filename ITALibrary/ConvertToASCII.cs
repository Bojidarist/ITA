using System;
using System.Drawing;
using System.Text;

namespace ITALibrary
{
    class ConvertToASCII
    {
        public static string Convert(Bitmap image, char whiteColorCharacter = ' ', char blackColorCharacter = '#', char rgbBelowHundred = '@',
            char rgbBelowHundredAndFifty = 'g', char rgbBelowTwoHundred = '$', char rgbBelowTwoHundredAndFifty = ':', char otherColorsCharacter = '.')
        {
            StringBuilder sb = new StringBuilder();

            for (int y = 0; y < image.Height; y++)
            {
                for (int x = 0; x < image.Width; x++)
                {
                    Color pixel = image.GetPixel(x, y);
                    if (pixel.R == 255 && pixel.G == 255 && pixel.B == 255)
                    {
                        sb.Append(whiteColorCharacter);
                    }
                    else if (pixel.R <= 50 && pixel.G <= 50 && pixel.B <= 50)
                    {
                        sb.Append(blackColorCharacter);
                    }
                    else if (pixel.R <= 100 && pixel.G <= 100 && pixel.B <= 100)
                    {
                        sb.Append(rgbBelowHundred);
                    }
                    else if (pixel.R <= 150 && pixel.G <= 150 && pixel.B <= 150)
                    {
                        sb.Append(rgbBelowHundredAndFifty);
                    }
                    else if (pixel.R <= 200 && pixel.G <= 200 && pixel.B <= 200)
                    {
                        sb.Append(rgbBelowTwoHundred);
                    }
                    else if (pixel.R <= 250 && pixel.G <= 250 && pixel.B <= 250)
                    {
                        sb.Append(rgbBelowTwoHundredAndFifty);
                    }
                    else
                    {
                        sb.Append(otherColorsCharacter);
                    }
                }
                sb.Append(Environment.NewLine);
            }
            return sb.ToString();
        }
    }
}
