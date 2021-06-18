using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaBiblioteca.Datos
{
    public class DUsuario
    {
        public bool Existe(string username, string password)
        {
            try
            {
                using (BibliotecaEntities db = new BibliotecaEntities())
                {
                    var exist = db.Usuario.Any(u => u.Username == username && u.Password == password);
                    return exist;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public RegresarUsuario_Result RegresarUsuario(string username, string password)
        {
             try
            {
                using (BibliotecaEntities db = new BibliotecaEntities())
                {
                    var user = db.RegresarUsuario(username, password).FirstOrDefault();
                    return user;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

    }
}
