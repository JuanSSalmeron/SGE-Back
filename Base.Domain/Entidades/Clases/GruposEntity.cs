using Base.Domain.Entidades.Core;
using Base.Domain.Entidades.Escuela;
using System.ComponentModel.DataAnnotations.Schema;

namespace Base.Domain.Entidades.Clases
{
    [Table("Tbl_Grupos")]
    public class GruposEntity : NombreEntity
    {

        // Relaciones
        public virtual ICollection<GruposAlumnosEntity> GruposAlumnos { get; set; }
        public virtual ICollection<GruposPeriodosEntity> GruposPeriodos { get; set; }
        public virtual ICollection<MateriaGrupoEntity> MateriaGrupos { get; set; }
    }
}
