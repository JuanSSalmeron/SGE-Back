using Base.Domain.Entidades.Clases;
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
    [Table("Tbl_Alumnos")]
    public class AlumnoEntity : BaseEntity
    {
        public int Matricula { get; set; }
        public string ContactoEmergencia { get; set; }
        public string NecesidadesEspeciales { get; set; }
        public DateTime FechaIngreso { get; set; }
        [ForeignKey(nameof(Persona))]
        public int IdPersona { get; set; }
        public virtual PersonaEntity Persona { get; set; }

        [ForeignKey(nameof(CursoEscolar))]
        public int IdCursoEscolar { get; set; }
        public virtual CursoEscolarEntity CursoEscolar { get; set; }

        public virtual ICollection<GruposAlumnosEntity> GruposAlumnos { get; set; }
    }
}
