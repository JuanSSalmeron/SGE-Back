using Base.Domain.DTOs.Core;

namespace Base.Domain.DTOs.Clases
{
    public class GruposAlumnosEntityDTO : NombreDTO
    {
        public int IdGrupo { get; set; }
        public int IdAlumno { get; set; }
    }
}
