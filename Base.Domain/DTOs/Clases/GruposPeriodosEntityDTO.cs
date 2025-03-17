using Base.Domain.DTOs.Core;

namespace Base.Domain.DTOs.Clases
{
    public class GruposPeriodosEntityDTO : NombreDTO
    {
        public int IdGrupo { get; set; }
        public int IdPeriodo { get; set; }
    }
}
