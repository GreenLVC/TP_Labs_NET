using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Entities
{
    public class UserModule: BusinessEntity
    {
        public int IdUsuario;
        public int IdModulo;
        public bool PermiteAlta;
        public bool PermiteBaja;
        public bool PermiteModificacion;
        public bool PermiteConsulta;
    }
}
