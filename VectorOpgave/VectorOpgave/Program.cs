using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VectorOpgave
{
    class Program
    {
        static void Main(string[] args)
        {
            Vector3D v1 = new Vector3D(2, 3, 4);
            Vector3D v2 = new Vector3D(5, 6, 7);

            Vector3D v3 = v1.AddVector(v2);

            Console.WriteLine(v1.GetLength());
            Console.WriteLine(v2.GetLength());
            Console.WriteLine(v3.GetLength());
            Console.ReadKey();

        }
    }
}
