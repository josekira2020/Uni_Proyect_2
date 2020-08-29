using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Uni_Proyect_2.Models.Estudiante
{
    public class Estudiante
    {
        public Guid EstudiantesId { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public Guid CiudadId { get; set; }
        public Guid MunicipioId { get; set; }
        public Guid CreadoPorUsuarioId { get; set; }
        public Guid ModificadoPorUsuarioId { get; set; }
        public DateTime FechadeCreacion { get; set; }
        public DateTime FechadeModificaion { get; set; }
        public string Correo { get; set; }
        public string Telefono { get; set; }
        public Byte Sexo { get; set; }
        public string Domicilio { get; set; }
    }
}