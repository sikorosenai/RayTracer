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
                    Ray ray1 = new Ray(1, 2,3);
                    Ray ray2 = new Ray(2, 3, 4);
                    Ray result = ray1 + ray2;
                    Ray result2 = Ray.Add(ray1, ray2);
                    Ray result3 = ray1 * 5.0f;

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
