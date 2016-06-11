using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class FacadeAgencia
    {
        public void insertarAgencia(AGENCIA objA)
        {
            using (var db = new AgenciaContext())
            {
                db.AGENCIAs.Add(objA);
                db.SaveChanges();
            }
        }

        public void modificarAgencia(AGENCIA objA)
        {
            using (var db = new AgenciaContext())
            {
                //db.AGENCIAs.
                //db.SaveChanges();
            }
        }
    }
}
