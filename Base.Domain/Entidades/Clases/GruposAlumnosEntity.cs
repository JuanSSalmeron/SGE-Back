using Base.Domain.Entidades.Core;
using Base.Domain.Entidades.Personas;
using System.ComponentModel.DataAnnotations.Schema;

namespace Base.Domain.Entidades.Clases
{
    [Table("Tbl_GruposAlumnos")]
    public class GruposAlumnosEntity : NombreEntity
    {
        [ForeignKey(nameof(Grupo))]
        public int IdGrupo { get; set; }
        public virtual GruposEntity Grupo { get; set; }

        [ForeignKey(nameof(Alumno))]
        public int IdAlumno { get; set; }
        public virtual AlumnoEntity Alumno { get; set; }

    }
}
