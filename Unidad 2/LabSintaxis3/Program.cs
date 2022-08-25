using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabSintaxis3
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] lista = new string[5];
            int cantIteraciones = 5;
            for (int i = 0; i < cantIteraciones; i++)
            {
                Console.WriteLine("Ingresar valor para la lista en " + i);
                lista[i] = Console.ReadLine();
            }
            for (int i = 4; i >= 0; i--)
            {
                Console.WriteLine(lista[i]);
                Console.ReadLine();
            }
        }
    }
}
