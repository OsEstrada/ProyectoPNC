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
        public static List<ListarEjemplares_Result> Listar()
        {
            DEjemplar Datos = new DEjemplar();
            return Datos.Listar();
        }

        public static List<BuscarEjemplares_Result> Buscar(string valor)
        {
            DEjemplar Datos = new DEjemplar();
            return Datos.Buscar(valor);
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
