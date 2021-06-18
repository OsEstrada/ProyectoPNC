using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaBiblioteca.Datos
{
    public class DPrestamo
    {
        public List<ListarPrestamos_Result> ListarPrestamos()
        {
            try
            {
                using (BibliotecaEntities db = new BibliotecaEntities())
                {
                    var list = db.ListarPrestamos().ToList();
                    return list;
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public List<ListarDevoluciones_Result> ListarDevoluciones()
        {
            try
            {
                using (BibliotecaEntities db = new BibliotecaEntities())
                {
                    var list = db.ListarDevoluciones().ToList();
                    return list;
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }


        public List<BuscarPrestamos_Result> BuscarPrestamos(string valor)
        {
            try
            {
                using (BibliotecaEntities db = new BibliotecaEntities())
                {
                    var list = db.BuscarPrestamos(valor).ToList();
                    return list;
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public List<BuscarDevoluciones_Result> BuscarDevoliciones(string valor)
        {
            try
            {
                using (BibliotecaEntities db = new BibliotecaEntities())
                {
                    var list = db.BuscarDevoluciones(valor).ToList();
                    return list;
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public string Insertar(Prestamo obj)
        {
            string rpta = "";
            try
            {
                using (BibliotecaEntities db = new BibliotecaEntities())
                {
                    db.Prestamo.Add(obj);
                    rpta = db.SaveChanges() > 0 ? "OK" : "No se inserto ningun registro";
                }
            }
            catch (Exception ex)
            {
                rpta = ex.Message;
            }
            return rpta;
        }

        public string Actualizar(Prestamo obj)
        {
            string rpta = "";
            try
            {
                using (BibliotecaEntities db = new BibliotecaEntities())
                {
                    db.Entry(obj).State = System.Data.Entity.EntityState.Modified;
                    rpta = db.SaveChanges() > 0 ? "OK" : "No se actualizo ningun registro";
                }
            }
            catch (Exception ex)
            {
                rpta = ex.Message;
            }
            return rpta;
        }

        public string Eliminar(int id)
        {
            string rpta = "";
            try
            {
                using (BibliotecaEntities db = new BibliotecaEntities())
                {
                    db.Prestamo.Remove(db.Prestamo.FirstOrDefault(l => l.IdPrestamo == id));
                    rpta = db.SaveChanges() > 0 ? "OK" : "No se elimino ningun registro";
                }
            }
            catch (Exception ex)
            {
                rpta = ex.Message;
            }
            return rpta;
        }
    }
}
