using SistemaBiblioteca.Datos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaBiblioteca.Negocio
{
    public class NEjemplar
    {
        public static List<ListarEjemplares_Result> Listar(int idLibro)
        {
            DEjemplar Datos = new DEjemplar();
            return Datos.Listar(idLibro);
        }

        public static List<ListarEjemplaresDisponibles_Result> ListarEjemplaresDisponibles()
        {
            DEjemplar Datos = new DEjemplar();
            return Datos.ListarEjemplaresDisponibles();
        }

        public static List<BuscarEjemplares_Result> Buscar(string valor, int idLibro)
        {
            DEjemplar Datos = new DEjemplar();
            return Datos.Buscar(valor, idLibro);
        }

        public static List<BuscarEjemplaresPorLibro_Result> BuscarPorLibro(string valor)
        {
            DEjemplar Datos = new DEjemplar();
            return Datos.BuscarEjemplaresPorLibro(valor);
        }

        public static List<BuscarEjemplaresPorCodigoLibro_Result> BuscarPorCodigoLibro(string valor)
        {
            DEjemplar Datos = new DEjemplar();
            return Datos.BuscarEjemplaresPorCodigoLibro(valor);
        }

        public static List<BuscarEjemplaresPorCodigoEjemplar_Result> BuscarPorCodigoEjemplar(string valor)
        {
            DEjemplar Datos = new DEjemplar();
            return Datos.BuscarEjemplaresPorCodigoEjemplar(valor);
        }

        public static List<BuscarEjemplaresPorEditorial_Result> BuscarPorEditorial(string valor)
        {
            DEjemplar Datos = new DEjemplar();
            return Datos.BuscarEjemplaresPorEditorial(valor);
        }

        public static string Insertar(int IdLibro, string Ubicacion, bool Estado, string Editorial, string Idioma, string Pais)
        {
            DEjemplar Datos = new DEjemplar();
            Ejemplar Obj = new Ejemplar();
            Obj.IdLibro = IdLibro;
            Obj.Ubicacion = Ubicacion;
            Obj.Editorial = Editorial;
            Obj.Idioma = Idioma;
            Obj.Pais = Pais;
            Obj.Estado = Estado;
            return Datos.Insertar(Obj);
        }

        public static string Actualizar(int IdEjemplar, int IdLibro, string Ubicacion, bool Estado, string Editorial, string Idioma, string Pais)
        {
            DEjemplar Datos = new DEjemplar();
            Ejemplar Obj = new Ejemplar();
            Obj.IdEjemplar = IdEjemplar;
            Obj.IdLibro = IdLibro;
            Obj.Ubicacion = Ubicacion;
            Obj.Editorial = Editorial;
            Obj.Idioma = Idioma;
            Obj.Pais = Pais;
            Obj.Estado = Estado;
            return Datos.Actualizar(Obj);
        }

        public static string Eliminar(int id)
        {
            DEjemplar Datos = new DEjemplar();
            return Datos.Eliminar(id);
        }
    }
}
