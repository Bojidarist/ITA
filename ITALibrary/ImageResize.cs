using System.Drawing;

namespace ITALibrary
{
    class ImageResize
    {
        public static Image ResizeImage(Image imgToResize, Size size)
        {
            return new Bitmap(imgToResize, size);
        }
    }
}
