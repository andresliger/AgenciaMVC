using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modelo;

namespace Controlador
{
    public class UsuarioDao
    {
        private FacadeAgencia objF;
        private USUARIO usuario;
        private List<USUARIO> usuarios;

        public USUARIO Usuario
        {
            get
            {
                return usuario;
            }

            set
            {
                usuario = value;
            }
        }

        public void actualizar()
        {
            objF.modificarUsuario(usuario);
        }

    }
}
