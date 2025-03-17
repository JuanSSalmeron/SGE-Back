using Base.Domain.DTOs.Escuela;
using Base.Domain.Entidades.Core;
using Base.Domain.Entidades.Escuela;
using System.ComponentModel.DataAnnotations.Schema;

namespace Base.Domain.Entidades.Clases
{
    [Table("Tbl_Unidades")]
    public class UnidadesEntity : NombreEntity
    {
        [ForeignKey(nameof(Materia))]
        public int IdMateria { get; set; }
        public virtual MateriasEntity Materia { get; set; }

        // Relaciones
        public virtual ICollection<CalificacionesEntity> Calificaciones { get; set; }
    }
}