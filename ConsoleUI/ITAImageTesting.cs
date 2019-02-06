using ITALibrary;
using System;
using System.Diagnostics;

namespace ConsoleUI
{
    class ITAImageTesting
    {
        public static void Test()
        {
            // Measuring time
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();

            // Printing image details
            ITAImage image = new ITAImage(@"ExampleImages/Octo.png");

            Console.WriteLine($"Original Image Path: { image.ImagePath }");
            Console.WriteLine($"Original Image Height { image.OriginalHeight }");
            Console.WriteLine($"Original Image Width { image.OriginalWidth }");
            image.ResizeImage(250, 60);
            image.colorCharacters.WhiteColorCharacter = '▒';
            image.colorCharacters.RGBBelowHundredAndFifty = '▓';
            image.colorCharacters.BlackColorCharacter = '█';
            image.colorCharacters.OtherColorsCharacter = '▒';
            //image.SaveToFile("Image.txt");

            string imageASCII = image.ToString();
            Console.WriteLine(imageASCII);

            // Printing elapsed time
            stopwatch.Stop();
            Console.WriteLine($"Elapsed Time: { stopwatch.Elapsed }");
            Console.WriteLine($"Elapsed Time(ms): { stopwatch.ElapsedMilliseconds }");
            Console.WriteLine($"Elapsed Time(ticks): { stopwatch.ElapsedTicks }");

            Console.ReadKey();
        }
    }
}
