using System;
using Clases;

namespace LabClases1
{
    class Program
    {
        static void Main(string[] args)
        {
            A claseA = new A();
            A claseC = new A("Messi");
            B claseB = new B();

            Console.WriteLine(claseC.MostrarNombre());
            Console.WriteLine(claseA.M1());
            Console.WriteLine(claseA.M2());
            Console.WriteLine(claseA.M3());
            Console.WriteLine(claseB.M4());
        }
    }
}
