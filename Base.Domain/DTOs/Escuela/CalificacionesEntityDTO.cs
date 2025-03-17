using Base.Domain.DTO.Core;

namespace Base.Domain.DTOs.Escuela
{
    public class CalificacionesEntityDTO : BaseDTO
    {
        public decimal Calificacion { get; set; }
        public int IdAlumno { get; set; }
        public int IdUnidad { get; set; }
    }
}
