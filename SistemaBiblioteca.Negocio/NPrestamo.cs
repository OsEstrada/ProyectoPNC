using SistemaBiblioteca.Datos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaBiblioteca.Negocio
{
    public class NPrestamo
    {
        public static List<ListarPrestamos_Result> ListarPrestamos()
        {
            DPrestamo Datos = new DPrestamo();
            return Datos.ListarPrestamos();
        }

        public static List<BuscarPrestamos_Result> BuscarPrestamos(string valor)
        {
            DPrestamo Datos = new DPrestamo();
            return Datos.BuscarPrestamos(valor);
        }

        public static List<ListarDevoluciones_Result> ListarDevoluciones()
        {
            DPrestamo Datos = new DPrestamo();
            return Datos.ListarDevoluciones();
        }

        public static List<BuscarDevoluciones_Result> BuscarDevoluciones(string valor)
        {
            DPrestamo Datos = new DPrestamo();
            return Datos.BuscarDevoliciones(valor);
        }

        public static string Insertar(int IdUsuario, int IdEjemplar, DateTime FechaPrestamo)
        {
            DPrestamo Datos = new DPrestamo();
            Prestamo Obj = new Prestamo();
            Obj.IdUsuario = IdUsuario;
            Obj.IdEjemplar = IdEjemplar;
            Obj.FechaPrestamo = FechaPrestamo;
            Obj.Estado = true;
            return Datos.Insertar(Obj);
        }

        public static string Actualizar(int idPrestamo, int IdUsuario, int IdEjemplar, DateTime FechaPrestamo, DateTime FechaDevolucion, bool Estado)
        {
            DPrestamo Datos = new DPrestamo();
            Prestamo Obj = new Prestamo();
            Obj.IdPrestamo = idPrestamo;
            Obj.IdUsuario = IdUsuario;
            Obj.IdEjemplar = IdEjemplar;
            Obj.FechaPrestamo = FechaPrestamo;
            Obj.FechaDevolucion = FechaDevolucion;
            Obj.Estado = Estado;
            return Datos.Actualizar(Obj);
        }

        public static string Devolver(int idPrestamo, DateTime FechaDevolucion)
        {
            DPrestamo Datos = new DPrestamo();
            Prestamo Obj = new Prestamo();
            return Datos.Devolver(idPrestamo, FechaDevolucion);
        }

    }
}
