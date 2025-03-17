using Base.Domain.DTOs.Core;
using static Base.Common.Enumeraciones.Enums;

namespace Base.Domain.DTOs.Escuela
{
    public class PeriodosEntityDTO : NombreDTO
    {
        public DateTime FechaInicio { get; set; }
        public DateTime FechaFin { get; set; }
        public EstatusPeriodo EstatusPeriodo { get; set; }
    }
}
