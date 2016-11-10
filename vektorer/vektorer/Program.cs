using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;


namespace vektorer
{
    public class Vector2D
    {
        //Fields
        private float x, y, z;
        //Properties
        public float X { get { return x; } }
        public float Y { get { return y; } }
        public float Z { get { return z; } }
        
        //Constructor
        public Vector2D(float x, float y, float z)
        {
            this.x = x;
            this.y = y;
            this.z = z;
        }
        
        //Methods
        public float CalcLength()
        {
            return (float)Math.Sqrt(x * x + y * y + z * z);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Vector2D v = new Vector2D(2, 3, 4);
            Console.WriteLine(v.CalcLength());
            //Debug.WriteLine(v.CalcLength());
        }
    }
}
