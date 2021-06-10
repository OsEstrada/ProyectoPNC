using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaBiblioteca.Datos
{
    public class DLEjemplar
    {
        public List<ListarEjemplares_Result> Listar()
        {
            try
            {
                using(BibliotecaEntities db = new BibliotecaEntities())
                {
                    var list = db.ListarEjemplares().ToList();
                    return list;
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }


        public List<BuscarEjemplares_Result> Buscar(string valor)
        {
            try
            {
                using (BibliotecaEntities db = new BibliotecaEntities())
                {
                    var list = db.BuscarEjemplares(valor).ToList();
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
                    db.Ejemplar.Remove(db.Ejemplar.FirstOrDefault(l => l.IdLibro == id));
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
