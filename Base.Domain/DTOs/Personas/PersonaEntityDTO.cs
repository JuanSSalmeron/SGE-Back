using Base.Domain.DTO.Core;

namespace Base.Domain.DTOs.Personas
{
    public class PersonaEntityDTO : BaseDTO
    {
        public string Nombre { get; set; }
        public string ApellidoPaterno { get; set; }
        public string ApellidoMaterno { get; set; }
        public DateTime FechaNacimiento { get; set; }
    }
}
