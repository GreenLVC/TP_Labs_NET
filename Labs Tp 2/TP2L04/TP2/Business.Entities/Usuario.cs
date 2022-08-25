using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Entities
{
    public class Usuario
    {
        public int ID;
        public string NombreUsuario;
        public string Clave;
        public string Nombre;
        public string Apellido;
        public string Email;
        public bool Habilitado;

        public BusinessEntity.States State { get; set; }
    }
}
