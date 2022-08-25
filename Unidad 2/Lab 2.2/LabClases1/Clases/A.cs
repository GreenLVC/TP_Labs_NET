using System;

namespace Clases
{
    public class A
    {
        public string nombreInstancia;
        public A()
        {
            nombreInstancia = "Instancia sin nombre";
        }
        public A(string nombre)
        {
            nombreInstancia = nombre;
        }

        public string MostrarNombre()
        {
            return nombreInstancia;
        }

        public string M1()
        {
            return "Metodo M1 invocado";
        }
        public string M2()
        {
            return "Metodo M2 invocado";
        }
        public string M3()
        {
            return "Metodo M3 invocado";
        }
    }
}
