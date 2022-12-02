using System;

namespace LostArkLogger.Types
{
    public struct Vector3F
    {
        public float X;
        public float Y;
        public float Z;

        private static float i21(long n)
        {
            if (n >> 20 == 1) return -(((~n >>> 0) + 1) & 0x1fffff); // 2's compelement
            return n;
        }
        public Vector3F(ulong value)
        {
            Z = i21((long)((value >> (2 * 21)) & 0x1fffff));
            Y = i21((long)((value >> 21) & 0x1fffff));
            X = i21((long)(value & 0x1fffff));
			/*
			TODO: real Vector3F implementation
			v13.m128_f32[0] = (float)((int)(v12 >> 10) >> 11);
			v14.m128_f32[0] = (float)((int)((_DWORD)v12 << 11) >> 11);
			v93 = (float)((int)(v12 >> 31) >> 11);
			*/
        }


        public override string ToString()
        {
            return $"vec3({X},{Y},{Z})"; //(x = topleft+ <- botright-, y = botleft+ <- topright-
        }

        public float DistanceTo(Vector3F target)
        {
            double a = target.X - X;
            double b = target.Y - Y;
            double c = target.Z - Z;
            return (float) Math.Sqrt(a * a + b * b + c * c);
        }

        public Vector3F MoveForvard(Vector3F target, int speed, long time)
        {
            if (time == 0 || speed == 0) return this;
            var toGo = (float) speed * time / TimeSpan.TicksPerSecond;
            var distance = DistanceTo(target);
            if (toGo >= distance || distance == 0) return target;
            Vector3F result;
            result.X = X + (target.X - X) * toGo / distance;
            result.Y = Y + (target.Y - Y) * toGo / distance;
            result.Z = Z + (target.Z - Z) * toGo / distance;
            return result;
        }

        public Angle GetHeading(Vector3F target)
        {
            return new Angle((short) (Math.Atan2(target.Y - Y, target.X - X) * 0x8000 / Math.PI));
        }
    }
}