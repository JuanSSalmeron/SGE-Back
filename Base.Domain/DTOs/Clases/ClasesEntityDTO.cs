using Base.Domain.DTOs.Core;

namespace Base.Domain.DTOs.Clases
{
    public class ClasesEntityDTO : NombreDTO
    {
        public int IdMateria { get; set; }
        public int IdProfesor { get; set; }
    }
}
