using System;

namespace Personas
{
    public class Persona
    {
        public string nombre;
        public string apellido;
        public int edad;
        public int dni;

        public Persona(string n, string a, int e, int d)
        {
            nombre = n;
            apellido = a;
            edad = e;
            dni = d;
            Console.WriteLine("La persona ha sido creada");
        }

        ~Persona()
        {
            Console.WriteLine("La instancia ha sido destruida");
        }

        public string Nombre {
            get => nombre;
            set {
                nombre = value;
            }
        }

        public string Apellido {
            get => apellido;
            set {
                apellido = value;
            }
        }

        public int Edad {
            get => edad;
            set {
                edad = value;
            }
        }

        public int Dni {
            get => dni;
            set {
                dni = value;
            }
        }

        public int getBirthYear ()
        {
            return DateTime.Now.Year - edad;
        }

        public string getFullName()
        {
            return nombre + apellido;
         }
    }
}
