using System;

namespace RayTracer
{
    class Program
    {
        static void Main(string[] args)
        {
            const int width = 256; 
            const int height = 256;
            Console.WriteLine("P3");
            Console.WriteLine(String.Format("{0} {1}\n255", width, height));

            for (int y = 0; y < height; y++)
            {
                for (int x = 0; x < width; x++)
                {
                    float r = x;
                    float g = y;
                    float b = x;

                    Console.Write(String.Format("{0} {1} {2} ", (int)r, (int)g, (int)b));

                }
                Console.WriteLine();
            }
        }
    }
}
