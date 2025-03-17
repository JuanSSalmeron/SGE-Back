using Base.Domain.DTO.Core;

namespace Base.Domain.DTOs.Core
{
    public abstract class NombreDTO : BaseDTO
    {
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
    }
}
