using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity.Core.Objects;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaBiblioteca.Datos
{
    public class DLibro
    {
        public List<ListarLibros_Result> Listar()
        {
            try
            {
                using(BibliotecaEntities db = new BibliotecaEntities())
                {
                    var list = db.ListarLibros().ToList();
                    return list;
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }


        public List<BuscarLibro_Result> Buscar(string valor)
        {
            try
            {
                using (BibliotecaEntities db = new BibliotecaEntities())
                {
                    var list = db.BuscarLibro(valor).ToList();
                    return list;
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public List<BuscarLibroPorId_Result> BuscarPorId(int valor)
        {
            try
            {
                using (BibliotecaEntities db = new BibliotecaEntities())
                {
                    var list = db.BuscarLibroPorId(valor).ToList();
                    return list;
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }


        public string Insertar(Libro obj)
        {
            string rpta = "";
            try
            {
                using (BibliotecaEntities db = new BibliotecaEntities())
                {
                    ObjectParameter returnId = new ObjectParameter("Id", typeof(int));
                    db.InsertarLibros(obj.Titulo, obj.Autor, obj.ISBN, obj.Materia, obj.AnioEdicion, obj.NoEdicion, obj.NoPaginas, obj.Descripcion, returnId);
                    rpta = Convert.ToInt32(returnId.Value) != -1 ? Convert.ToString(returnId.Value) : "No se inserto ningun registro";
                }
            }
            catch (Exception ex)
            {
                rpta = ex.Message;
            }
            return rpta;
        }

        public string Actualizar(Libro obj)
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
                    db.Libro.Remove(db.Libro.FirstOrDefault(l => l.IdLibro == id));
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
