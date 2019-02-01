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

            Console.WriteLine($"Original Image Path: { image.ImagePath }");
            Console.WriteLine($"Original Image Height { image.OriginalHeight }");
            Console.WriteLine($"Original Image Width { image.OriginalWidth }");
            image.ResizeImage(50, 35);
            Console.WriteLine(image);

            // Printing elapsed time
            stopwatch.Stop();
            Console.WriteLine($"Elapsed Time: { stopwatch.Elapsed }");
            Console.WriteLine($"Elapsed Time(ms): { stopwatch.ElapsedMilliseconds }");  
            Console.WriteLine($"Elapsed Time(ticks): { stopwatch.ElapsedTicks }");

            Console.ReadKey();
        }
    }
}
