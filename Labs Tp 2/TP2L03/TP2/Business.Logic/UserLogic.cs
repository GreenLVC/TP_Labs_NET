using Data.Database;
using Business.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Business.Logic
{
    public class UserLogic: BusinessLogic
    {
        public UsuarioAdapter UsuarioData;

        public UserLogic(UsuarioAdapter usuarioData)
        {
            UsuarioData = usuarioData;
        }

        public Usuario GetOne(int ID)
        {
            return UsuarioData.GetOne(ID);
        }
        public List<Usuario> GetAll()
        {
            return UsuarioData.GetAll();
        }
        public void Save(Usuario usuario)
        {
            UsuarioData.Save(usuario);
        }
        public void Delete(int ID)
        {
            UsuarioData.Delete(ID);
        }
    }
}
