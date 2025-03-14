using Base.Domain.Entidades.Clases;
using Base.Domain.Entidades.Core;
using Base.Domain.Entidades.Personas;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Base.Domain.Entidades.Escuela
{
    [Table("Tbl_Calificaciones")]
    public class CalificacionesEntity : BaseEntity
    {
        public decimal Calificacion { get; set; }

        [ForeignKey(nameof(Alumno))]
        public int IdAlumno { get; set; }
        public virtual AlumnoEntity Alumno { get; set; }

        [ForeignKey(nameof(Unidad))]
        public int IdUnidad { get; set; }
        public virtual UnidadesEntity Unidad { get; set; }
    }
}
