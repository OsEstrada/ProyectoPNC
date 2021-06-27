using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaBiblioteca.Datos
{
    public class DEjemplar
    {
        public List<ListarEjemplares_Result> Listar(int idLibro)
        {
            try
            {
                using(BibliotecaEntities db = new BibliotecaEntities())
                {
                    var list = db.ListarEjemplares(idLibro).ToList();
                    return list;
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public List<ListarTodosEjemplares_Result> ListarTodos()
        {
            try
            {
                using (BibliotecaEntities db = new BibliotecaEntities())
                {
                    var list = db.ListarTodosEjemplares().ToList();
                    return list;
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public List<ListarEjemplaresDisponibles_Result> ListarEjemplaresDisponibles()
        {
            try
            {
                using (BibliotecaEntities db = new BibliotecaEntities())
                {
                    var list = db.ListarEjemplaresDisponibles().ToList();
                    return list;
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public List<BuscarEjemplaresPorCodigoEjemplar_Result> BuscarEjemplaresPorCodigoEjemplar(string valor)
        {
            try
            {
                using (BibliotecaEntities db = new BibliotecaEntities())
                {
                    var list = db.BuscarEjemplaresPorCodigoEjemplar(valor).ToList();
                    return list;
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public List<BuscarEjemplaresPorCodigoLibro_Result> BuscarEjemplaresPorCodigoLibro(string valor)
        {
            try
            {
                using (BibliotecaEntities db = new BibliotecaEntities())
                {
                    var list = db.BuscarEjemplaresPorCodigoLibro(valor).ToList();
                    return list;
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public List<BuscarEjemplaresPorLibro_Result> BuscarEjemplaresPorLibro(string valor)
        {
            try
            {
                using (BibliotecaEntities db = new BibliotecaEntities())
                {
                    var list = db.BuscarEjemplaresPorLibro(valor).ToList();
                    return list;
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public List<BuscarEjemplaresPorEditorial_Result> BuscarEjemplaresPorEditorial(string valor)
        {
            try
            {
                using (BibliotecaEntities db = new BibliotecaEntities())
                {
                    var list = db.BuscarEjemplaresPorEditorial(valor).ToList();
                    return list;
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public List<BuscarEjemplares_Result> Buscar(string valor, int IdLibro)
        {
            try
            {
                using (BibliotecaEntities db = new BibliotecaEntities())
                {
                    var list = db.BuscarEjemplares(valor, IdLibro).ToList();
                    return list;
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public List<BuscarEjemplaresSinIdLibro_Result> BuscarSinIdLibro(string valor)
        {
            try
            {
                using (BibliotecaEntities db = new BibliotecaEntities())
                {
                    var list = db.BuscarEjemplaresSinIdLibro(valor).ToList();
                    return list;
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }


        public string Insertar(Ejemplar obj)
        {
            string rpta = "";
            try
            {
                using (BibliotecaEntities db = new BibliotecaEntities())
                {
                    db.Ejemplar.Add(obj);
                    rpta = db.SaveChanges() > 0 ? "OK" : "No se inserto ningun registro";
                }
            }
            catch (Exception ex)
            {
                rpta = ex.Message;
            }
            return rpta;
        }

        public string Actualizar(Ejemplar obj)
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
                    db.Ejemplar.Remove(db.Ejemplar.FirstOrDefault(l => l.IdEjemplar == id));
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
