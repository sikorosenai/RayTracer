using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace RayTracer
{
    class Ray
    {
        float x; 
        float y;
        float z;
        public Ray(float x, float y, float z)
        {
            this.x = x;
            this.y = y;
            this.z = z;
        }
        public Ray(float x = 0.0f)
        {
            this.x = x;
            this.y = x;
            this.z = x;
        }

        public void Set(float x, float y, float z)
        {
            this.x = x;
            this.y = y;
            this.z = z;
        }

        public float Magnitude()
        {
            float m = x * x + y * y + z * z;
            m = (float)Math.Sqrt(m);
            return m;
        }

        public void Normalize()
        {
            float m = Magnitude();
            x = x / m;
            y = y / m;
            z = z / m;
            Debug.Assert(Math.Abs(Magnitude() - 1.0f) < 0.005f);
        }

        public static Ray operator +(Ray r1, Ray r2)
        {
            Ray retur = new Ray(r1.x + r2.x, r1.y + r2.y, r1.z + r2.z);
            return retur;
        }
        public static Ray Add(Ray r1, Ray r2)
        {
            return r1 + r2;
        }

        public static Ray operator -(Ray r1, Ray r2)
        {
            Ray retur = new Ray(r1.x - r2.x, r1.y - r2.y, r1.z - r2.z);
            return retur;
        }
        public static Ray operator *(Ray r1, float val)
        {
            Ray retur = new Ray(r1.x * val, r1.y * val, r1.z * val);
            return retur;
        }

    }
}
