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

            Console.WriteLine($"Image Path: { image.ImagePath }");
            Console.WriteLine($"Image Height { image.Height }");
            Console.WriteLine($"Image Width { image.Width }");
            Console.WriteLine(image);

            // Printing elapsed time
            stopwatch.Stop();
            Console.WriteLine($"Elapsed Time: { stopwatch.Elapsed }");
            Console.WriteLine($"Elapsed Time(ms): { stopwatch.ElapsedMilliseconds }");  
            Console.WriteLine($"Elapsed Time(ticks): { stopwatch.ElapsedTicks }");  
        }
    }
}
