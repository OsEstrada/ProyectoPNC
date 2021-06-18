using SistemaBiblioteca.Datos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaBiblioteca.Negocio
{
    public class NUsuario
    {
        public static RegresarUsuario_Result UsuarioLoggeado;
        public static bool Login(string username, string password)
        {
            DUsuario Datos = new DUsuario();
            if(Datos.Existe(username, password))
            {
                UsuarioLoggeado = Datos.RegresarUsuario(username, password);
                return true;
            }
            else
            {
                return false;
            }
        }

        public static void CerrarSesion(string username, string password)
        {
            if (UsuarioLoggeado != null)
                UsuarioLoggeado = null;
        }

    }
}
