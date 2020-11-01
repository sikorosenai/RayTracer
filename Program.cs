using System;
using System.ComponentModel;
using System.Net.NetworkInformation;
using System.Text.Json;
using Color = RayTracer.Vec3;

namespace RayTracer
{
    class Program
    {
        static Color RayColor(Ray r)
        {
            Vec3 normalizeDirection = r.direction;
            normalizeDirection.Normalize();
            float t = 0.5f * (normalizeDirection.y + 1);
            return new Color(1.0f) * (1 - t) + new Color(0.5f, 0.7f, 1.0f) * t;
        }
        static void Main(string[] args)
        {
            const float aspectRatio = 16.0f / 9.0f; 
            const int width = 256; 
            const int height = (int)(width/aspectRatio);

            //camera
            float viewportHeight = 2.0f;
            float viewportWidth = aspectRatio * viewportHeight;
            float focalLength = 1.0f;
            Vec3 origin = new Vec3(0.0f);
            Vec3 horizontal = new Vec3(viewportWidth, 0, 0);
            Vec3 vertical = new Vec3(0, viewportHeight, 0);
            Vec3 lowerLeft = origin - horizontal / 2 - vertical / 2 - new Vec3(0, 0, focalLength);
            Console.WriteLine("P3");
            Console.WriteLine(String.Format("{0} {1}\n255", width, height));

            for (int y = height - 1; y >= 0; y--)
            {
                for (int x = 0; x < width; x++)
                {
                    float u = (float)x / (width - 1);
                    float v = (float)y / (height - 1);
                    Ray r = new Ray(origin, lowerLeft + horizontal * u + vertical * v);
                    Color outputColor = RayColor(r) * 255;
                    Console.Write(String.Format("{0} {1} {2} ", outputColor.x, outputColor.y, outputColor.z));
                }

                Console.WriteLine();
            }
        }
    }
}
