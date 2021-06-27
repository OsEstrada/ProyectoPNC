﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SistemaBiblioteca.Datos
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class BibliotecaEntities : DbContext
    {
        public BibliotecaEntities()
            : base("name=BibliotecaEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Ejemplar> Ejemplar { get; set; }
        public virtual DbSet<Libro> Libro { get; set; }
        public virtual DbSet<Prestamo> Prestamo { get; set; }
        public virtual DbSet<Rol> Rol { get; set; }
        public virtual DbSet<Usuario> Usuario { get; set; }
    
        public virtual ObjectResult<BuscarDevoluciones_Result> BuscarDevoluciones(string valor)
        {
            var valorParameter = valor != null ?
                new ObjectParameter("valor", valor) :
                new ObjectParameter("valor", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<BuscarDevoluciones_Result>("BuscarDevoluciones", valorParameter);
        }
    
        public virtual ObjectResult<BuscarEjemplares_Result> BuscarEjemplares(string valor, Nullable<int> idLibro)
        {
            var valorParameter = valor != null ?
                new ObjectParameter("valor", valor) :
                new ObjectParameter("valor", typeof(string));
    
            var idLibroParameter = idLibro.HasValue ?
                new ObjectParameter("idLibro", idLibro) :
                new ObjectParameter("idLibro", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<BuscarEjemplares_Result>("BuscarEjemplares", valorParameter, idLibroParameter);
        }
    
        public virtual ObjectResult<BuscarLibro_Result> BuscarLibro(string valor)
        {
            var valorParameter = valor != null ?
                new ObjectParameter("valor", valor) :
                new ObjectParameter("valor", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<BuscarLibro_Result>("BuscarLibro", valorParameter);
        }
    
        public virtual ObjectResult<BuscarPrestamos_Result> BuscarPrestamos(string valor)
        {
            var valorParameter = valor != null ?
                new ObjectParameter("valor", valor) :
                new ObjectParameter("valor", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<BuscarPrestamos_Result>("BuscarPrestamos", valorParameter);
        }
    
        public virtual int InsertarLibros(string titulo, string autor, string iSBN, string materia, string anioEdicion, Nullable<int> noEdicion, Nullable<int> noPaginas, string descripcion, ObjectParameter id)
        {
            var tituloParameter = titulo != null ?
                new ObjectParameter("Titulo", titulo) :
                new ObjectParameter("Titulo", typeof(string));
    
            var autorParameter = autor != null ?
                new ObjectParameter("Autor", autor) :
                new ObjectParameter("Autor", typeof(string));
    
            var iSBNParameter = iSBN != null ?
                new ObjectParameter("ISBN", iSBN) :
                new ObjectParameter("ISBN", typeof(string));
    
            var materiaParameter = materia != null ?
                new ObjectParameter("Materia", materia) :
                new ObjectParameter("Materia", typeof(string));
    
            var anioEdicionParameter = anioEdicion != null ?
                new ObjectParameter("AnioEdicion", anioEdicion) :
                new ObjectParameter("AnioEdicion", typeof(string));
    
            var noEdicionParameter = noEdicion.HasValue ?
                new ObjectParameter("NoEdicion", noEdicion) :
                new ObjectParameter("NoEdicion", typeof(int));
    
            var noPaginasParameter = noPaginas.HasValue ?
                new ObjectParameter("NoPaginas", noPaginas) :
                new ObjectParameter("NoPaginas", typeof(int));
    
            var descripcionParameter = descripcion != null ?
                new ObjectParameter("Descripcion", descripcion) :
                new ObjectParameter("Descripcion", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("InsertarLibros", tituloParameter, autorParameter, iSBNParameter, materiaParameter, anioEdicionParameter, noEdicionParameter, noPaginasParameter, descripcionParameter, id);
        }
    
        public virtual ObjectResult<ListarDevoluciones_Result> ListarDevoluciones()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<ListarDevoluciones_Result>("ListarDevoluciones");
        }
    
        public virtual ObjectResult<ListarEjemplares_Result> ListarEjemplares(Nullable<int> idLibro)
        {
            var idLibroParameter = idLibro.HasValue ?
                new ObjectParameter("idLibro", idLibro) :
                new ObjectParameter("idLibro", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<ListarEjemplares_Result>("ListarEjemplares", idLibroParameter);
        }
    
        public virtual ObjectResult<ListarLibros_Result> ListarLibros()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<ListarLibros_Result>("ListarLibros");
        }
    
        public virtual ObjectResult<ListarPrestamos_Result> ListarPrestamos()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<ListarPrestamos_Result>("ListarPrestamos");
        }
    
        public virtual ObjectResult<Login_Result> Login(string username, string password)
        {
            var usernameParameter = username != null ?
                new ObjectParameter("username", username) :
                new ObjectParameter("username", typeof(string));
    
            var passwordParameter = password != null ?
                new ObjectParameter("password", password) :
                new ObjectParameter("password", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Login_Result>("Login", usernameParameter, passwordParameter);
        }
    
        public virtual ObjectResult<BuscarPrestamosActivosProfesor_Result> BuscarPrestamosActivosProfesor(Nullable<int> valor)
        {
            var valorParameter = valor.HasValue ?
                new ObjectParameter("valor", valor) :
                new ObjectParameter("valor", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<BuscarPrestamosActivosProfesor_Result>("BuscarPrestamosActivosProfesor", valorParameter);
        }
    
        public virtual ObjectResult<BuscarProfesor_Result> BuscarProfesor(string valor)
        {
            var valorParameter = valor != null ?
                new ObjectParameter("valor", valor) :
                new ObjectParameter("valor", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<BuscarProfesor_Result>("BuscarProfesor", valorParameter);
        }
    
        public virtual ObjectResult<ListarProfesores_Result> ListarProfesores()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<ListarProfesores_Result>("ListarProfesores");
        }
    
        public virtual ObjectResult<ListarEjemplaresDisponibles_Result> ListarEjemplaresDisponibles()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<ListarEjemplaresDisponibles_Result>("ListarEjemplaresDisponibles");
        }
    }
}
