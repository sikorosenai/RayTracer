using System;
using System.Collections.Generic;
using System.Text;

namespace RayTracer
{
    class Ray
    {
        public Vec3 origin = new Vec3(0.0f, 0.0f, 0.0f);
        public Vec3 direction = new Vec3(1.0f, 0.0f, 0.0f);
        public Ray(Vec3 o, Vec3 d)
        {
            this.origin = o;
            this.direction = d;
        }
        public Vec3 at(float t)
        {
            return origin + direction * t;

        }
    }
}
