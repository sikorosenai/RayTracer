using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace RayTracer
{
    class Vec3
    {
        public float x; 
        public float y;
        public float z;

        public Vec3(float x, float y, float z)
        {
            this.x = x;
            this.y = y;
            this.z = z;
        }
        public Vec3(float x = 0.0f)
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

        public Vec3 Add(Vec3 val)
        {
            return new Vec3(this.x + val.x, this.y + val.y, this.z + val.z);
        }
       

        public void Normalize()
        {
            float m = Magnitude();
            x = x / m;
            y = y / m;
            z = z / m;
            Debug.Assert(Math.Abs(Magnitude() - 1.0f) < 0.005f);
        }

        public static Vec3 operator +(Vec3 r1, Vec3 r2)
        {
            Vec3 retur = new Vec3(r1.x + r2.x, r1.y + r2.y, r1.z + r2.z);
            return retur;
        }
        public static Vec3 Add(Vec3 r1, Vec3 r2)
        {
            return r1 + r2;
        }

        public static Vec3 operator -(Vec3 r1, Vec3 r2)
        {
            Vec3 retur = new Vec3(r1.x - r2.x, r1.y - r2.y, r1.z - r2.z);
            return retur;
        }
        public static Vec3 operator *(Vec3 r1, float val)
        {
            Vec3 retur = new Vec3(r1.x * val, r1.y * val, r1.z * val);
            return retur;
        }
        public static Vec3 operator /(Vec3 r1, float val)
        {
            Vec3 retur = new Vec3(r1.x / val, r1.y / val, r1.z / val);
            return retur;
        }

        public static float Dot (Vec3 a, Vec3 b)
        {
            return (a.x * b.x) + (a.y * b.y) + (a.z * b.z);
        }

    }
    
}
