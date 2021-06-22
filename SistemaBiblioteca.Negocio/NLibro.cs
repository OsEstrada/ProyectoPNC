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

        public static string Insertar(string Titulo, string Autor, string ISBN, string AnioEdicion, int NoEdicion, int NoPaginas, string Descripcion)
        {
            DLibro Datos = new DLibro();
            Libro Obj = new Libro();
            Obj.Autor = Autor;
            Obj.Titulo = Titulo;
            Obj.ISBN = ISBN;
            Obj.Materia = ISBN;
            Obj.AnioEdicion = AnioEdicion;
            Obj.NoEdicion = NoEdicion;
            Obj.NoPaginas = NoPaginas;
            Obj.Descripcion = Descripcion;
            return Datos.Insertar(Obj);
        }

        public static string Actualizar(int IdLibro, string Titulo, string Autor, string ISBN, string AnioEdicion, int NoEdicion, int NoPaginas, string Descripcion)
        {
            DLibro Datos = new DLibro();
            Libro Obj = new Libro();
            Obj.IdLibro = IdLibro;
            Obj.Autor = Autor;
            Obj.Titulo = Titulo;
            Obj.ISBN = ISBN;
            Obj.Materia = ISBN;
            Obj.AnioEdicion = AnioEdicion;
            Obj.NoEdicion = NoEdicion;
            Obj.NoPaginas = NoPaginas;
            Obj.Descripcion = Descripcion;
            return Datos.Actualizar(Obj);
        }

        public static string Eliminar(int id)
        {
            DLibro Datos = new DLibro();
            return Datos.Eliminar(id);
        }

    }
}
