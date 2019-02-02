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
            ITAImage image = new ITAImage(@"ExampleImages/Penguin.jpg");
            string imageASCII = image.ToString();

            Console.WriteLine($"Original Image Path: { image.ImagePath }");
            Console.WriteLine($"Original Image Height { image.OriginalHeight }");
            Console.WriteLine($"Original Image Width { image.OriginalWidth }");
            image.ResizeImage(750, 240);
            image.SaveToFile("Image.txt");
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
