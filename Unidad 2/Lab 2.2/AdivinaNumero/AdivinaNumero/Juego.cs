using System;

namespace AdivinaNumero
{
    public class Juego
    {
        private int _record;

        private Juego()
        {
            throw new System.NotImplementedException();
        }

        public void ComenzarJuego()
        {
            throw new System.NotImplementedException();
        }

        private void CompararRecord(int intento)
        {
            if (_record > intento)
            {
                Console.WriteLine("Felicidades, has superado el record");
            }
            else { Console.WriteLine("No has superado el record. Siga participando."); }
        }

        private bool Continuar()
        {
            Console.WriteLine("¿Seguir jugando? Si/No");
            string respuesta = Console.ReadLine();
            if (respuesta == "Si" || respuesta == "si")
            {
                return true;
            }
            else { return false; }
        }

        private int PreguntarMaximo()
        {
            Console.WriteLine("Ingrese el máximo de los números a generar");
            string maxNumero = Console.ReadLine();
            return Int32.Parse(maxNumero);
        }

        private int PreguntarNumero()
        {
            Console.WriteLine("Ingrese un número");
            string numero = Console.ReadLine();
            return Int32.Parse(numero);
        }
    }
}
