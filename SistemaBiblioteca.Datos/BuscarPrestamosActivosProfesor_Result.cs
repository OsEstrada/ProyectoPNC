//------------------------------------------------------------------------------
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
    
    public partial class BuscarPrestamosActivosProfesor_Result
    {
        public int IdUsuario { get; set; }
        public int Id { get; set; }
        public string Profesor { get; set; }
        public string Titulo { get; set; }
        public int Numero_Ejemplar { get; set; }
        public System.DateTime Fecha_Prestamo { get; set; }
        public Nullable<System.DateTime> Fecha_Limite_de_Devolucion { get; set; }
    }
}
