//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Uni_Proyect_2.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class ClasesEstudiante
    {
        public System.Guid Id { get; set; }
        public System.Guid ClaseId { get; set; }
        public System.Guid EstudianteId { get; set; }
        public System.Guid CreadoPorUsuarioId { get; set; }
        public System.Guid ModificadoPorUsuarioId { get; set; }
        public System.DateTime FechaDeCreacion { get; set; }
        public System.DateTime FechaDeModificacion { get; set; }
    
        public virtual Clases Clases { get; set; }
        public virtual Estudiantes Estudiantes { get; set; }
    }
}
