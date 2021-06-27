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
        public static Login_Result Login(string username, string password)
        {
            DUsuario Datos = new DUsuario();
            if(Datos.Existe(username, password))
            {
                return Datos.Login(username, password);
            }
            else
            {
                return null;
            }
        }

        public static List<ListarProfesores_Result> ListarProfesores()
        {
            DUsuario Datos = new DUsuario();
            return Datos.ListarProfesores();
        }

        public static List<BuscarProfesor_Result> BuscarProfesor(string valor)
        {
            DUsuario Datos = new DUsuario();
            return Datos.BuscarProfesor(valor);
        }


    }
}
