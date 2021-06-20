using SistemaBiblioteca.Datos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaBiblioteca.Negocio
{
    public class NLibro
    {
        public static List<ListarLibros_Result> Listar()
        {
            DLibro Datos = new DLibro();
            return Datos.Listar();
        }

        public static List<BuscarLibro_Result> Buscar(string valor)
        {
            DLibro Datos = new DLibro();
            return Datos.Buscar(valor);
        }

        public static string Insertar(string Nombre, string Autor, string ISBN)
        {
            DLibro Datos = new DLibro();
            Libro Obj = new Libro();
            Obj.Autor = Autor;
            Obj.Nombre = Nombre;
            Obj.ISBN = ISBN;
            return Datos.Insertar(Obj);
        }

        public static string Actualizar(int id, string Nombre, string Autor, string ISBN)
        {
            DLibro Datos = new DLibro();
            Libro Obj = new Libro();
            Obj.IdLibro = id;
            Obj.Autor = Autor;
            Obj.Nombre = Nombre;
            Obj.ISBN = ISBN;
            return Datos.Actualizar(Obj);
        }

        public static string Eliminar(int id)
        {
            DLibro Datos = new DLibro();
            return Datos.Eliminar(id);
        }

    }
}
