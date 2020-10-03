using System;
using System.ComponentModel;
using System.Text.Json;

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
                    Vec3 origin = new Vec3(1, 2, 3);
                    Vec3 direction = new Vec3(10, 0, 0);

                    Ray r1 = new Ray(origin, direction);
                    
                    var pt = r1.at(2.0f);

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
