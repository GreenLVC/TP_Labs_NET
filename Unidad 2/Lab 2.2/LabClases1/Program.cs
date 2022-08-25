using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Clases;

namespace LabClases1
{
    class Program
    {
        static void Main(string[] args)
        {
            A a = new A();
            B b = new B();
            Console.WriteLine(a.MostrarNombre());
            Console.WriteLine(a.M1());
            Console.WriteLine(a.M2());
            Console.WriteLine(a.M3());
            Console.WriteLine(b.MostrarNombre());
            Console.WriteLine(b.M4());
            Console.ReadLine();
        }
    }
}
