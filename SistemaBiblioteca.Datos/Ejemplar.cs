//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SistemaBiblioteca.Datos
{
    using System;
    using System.Collections.Generic;
    
    public partial class Ejemplar
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Ejemplar()
        {
            this.Prestamo = new HashSet<Prestamo>();
        }
    
        public int IdEjemplar { get; set; }
        public Nullable<int> IdLibro { get; set; }
        public string Ubicacion { get; set; }
        public string Editorial { get; set; }
        public string Idioma { get; set; }
        public string Pais { get; set; }
        public Nullable<bool> Estado { get; set; }
    
        public virtual Libro Libro { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Prestamo> Prestamo { get; set; }
    }
}
