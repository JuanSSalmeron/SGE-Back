using Base.Domain.DTO.Core;
using Base.Domain.Entidades.Core;
using System.ComponentModel.DataAnnotations.Schema;

namespace Base.Domain.DTOs.Personas
{
    public class ProfesorEntityDTO : BaseDTO
    {
        public int NoEmpleado { get; set; }
        public string Especialidad { get; set; }
        public string GradoEstudios { get; set; }
        public string CedulaProfesional { get; set; }
        public DateTime FechaIngreso { get; set; }
        public int IdPersona { get; set; }
    }
}
