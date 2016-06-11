using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Modelo;
using System.Threading.Tasks;

namespace Controlador
{
    public class RegistroDAO
    {
        public static Boolean registrarUsuario(String nombre, String telf, String email, String password)
        {
            Utils.Encrypt.MD5HashMethod(password);

            return true;
        }
    }
}
