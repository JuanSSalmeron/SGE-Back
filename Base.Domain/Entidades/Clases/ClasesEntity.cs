using Base.Domain.Entidades.Core;
using Base.Domain.Entidades.Escuela;
using Base.Domain.Entidades.Personas;
using System.ComponentModel.DataAnnotations.Schema;

namespace Base.Domain.Entidades.Clases
{
    [Table("Tbl_Clases")]
    public class ClasesEntity : NombreEntity
    {
        [ForeignKey(nameof(Materias))]
        public int IdMateria { get; set; }
        public virtual MateriasEntity Materias { get; set; }

        [ForeignKey(nameof(Profesor))]
        public int IdProfesor { get; set; }
        public virtual ProfesorEntity Profesor { get; set; }
    }
}
