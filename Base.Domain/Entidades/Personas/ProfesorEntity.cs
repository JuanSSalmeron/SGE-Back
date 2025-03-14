using Base.Domain.Entidades.Core;
using Base.Domain.Entidades.Escuela;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Base.Domain.Entidades.Personas
{
    [Table("Tbl_Profesores")]
    public class ProfesorEntity : BaseEntity
    {
        public int NoEmpleado { get; set; }
        public string Especialidad { get; set; }
        public string GradoEstudios { get; set; }
        public string CedulaProfesional { get; set; }
        public DateTime FechaIngreso { get; set; }

        [ForeignKey(nameof(Persona))]
        public int IdPersona { get; set; }
        public virtual PersonaEntity Persona { get; set; }
    }
}
