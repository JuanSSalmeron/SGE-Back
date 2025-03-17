using Base.Domain.DTOs.Core;

namespace Base.Domain.DTOs.Clases
{
    public class MateriaGrupoEntityDTO : NombreDTO
    {
        public int IdMateria { get; set; }
        public int IdGrupo { get; set; }
    }
}
