﻿//------------------------------------------------------------------------------
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
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class ProyectoEntities : DbContext
    {
        public ProyectoEntities()
            : base("name=ProyectoEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Carrera> Carrera { get; set; }
        public virtual DbSet<Clases> Clases { get; set; }
        public virtual DbSet<ClasesEstudiante> ClasesEstudiante { get; set; }
        public virtual DbSet<Departamento> Departamento { get; set; }
        public virtual DbSet<Estudiantes> Estudiantes { get; set; }
        public virtual DbSet<Facultad> Facultad { get; set; }
        public virtual DbSet<Municipio> Municipio { get; set; }
        public virtual DbSet<Rol> Rol { get; set; }
        public virtual DbSet<usuarios> usuarios { get; set; }
    }
}