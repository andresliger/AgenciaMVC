using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controlador
{
    public class LoginDAO
    {
        public static Boolean validateLogin(String username, String password)
        {
            Utils.Encrypt.MD5HashMethod(password);
            return true;
        }
    }
}
