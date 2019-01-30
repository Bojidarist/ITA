using System.Drawing;
using System.IO;

namespace ITALibrary
{
    class ConvertToBitmap
    {
        public static Bitmap Convert(string fileName)
        {
            Bitmap bitmap;
            using (Stream bmpStream = File.Open(fileName, FileMode.Open))
            {
                Image image = Image.FromStream(bmpStream);

                bitmap = new Bitmap(image);
            }
            return bitmap;
        }
    }
}
