using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VectorOpgave
{
    public class Vector3D
    {
        private float x, y, z;

        public float X { get { return x; } }
        public float Y { get { return y; } }
        public float Z { get { return z; } }

        public Vector3D(float x, float y, float z)
        {
            this.x = x;
            this.y = y;
            this.z = z;
        }

        public float GetLength()
        {
            return (float) Math.Sqrt(x * x + y * y + z * z);
        }

        public Vector3D AddVector(Vector3D otherVector)
        {
            var resultingVector = new Vector3D(this.X + otherVector.X, this.Y+otherVector.Y, this.Z+otherVector.Z);
            return resultingVector;
        }



    }
}
