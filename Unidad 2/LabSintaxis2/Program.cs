using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabSintaxis2
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputTexto;
            Console.WriteLine("Ingrese un texto");
            inputTexto = Console.ReadLine();
            if (inputTexto == String.Empty) {
                Console.WriteLine("No se ingresó ningun texto");
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("Seleccione una opción");
                Console.WriteLine("1. "+ inputTexto.ToUpper());
                Console.WriteLine("2. "+ inputTexto.ToLower());
                Console.WriteLine("3. "+ inputTexto.Length);
                ConsoleKeyInfo opcion = Console.ReadKey(); // No me toma los números del numpad?

    // OPCIONES CON IF
                //if (opcion.Key == ConsoleKey.D1) {
                //    Console.WriteLine(inputTexto.ToUpper());
                //    Console.ReadKey();
                //}
                //else if(opcion.Key == ConsoleKey.D2)
                //    {
                //        Console.WriteLine(inputTexto.ToLower());
                //    Console.ReadKey();
                //}
                //else if (opcion.Key == ConsoleKey.D3)
                //    {
                //        Console.WriteLine(inputTexto.Length);
                //        Console.ReadKey();
                //}
                //else
                //{
                //    Console.WriteLine("No se ingresó ninguna opcion");
                //    Console.ReadKey();
                //}
                
    // OPCIONES CON CASE
                switch (opcion.Key)
                {
                    case ConsoleKey.D1:
                        Console.WriteLine(inputTexto.ToUpper());
                        Console.ReadKey();
                        break;

                    case ConsoleKey.D2:
                        Console.WriteLine(inputTexto.ToLower());
                        Console.ReadKey();
                        break;

                    case ConsoleKey.D3:
                        Console.WriteLine(inputTexto.Length);
                        Console.ReadKey();
                        break;
                }

            }

        }
    }
}
