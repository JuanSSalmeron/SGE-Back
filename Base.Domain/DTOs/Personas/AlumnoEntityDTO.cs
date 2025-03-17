using Base.Domain.DTO.Core;
using Base.Domain.Entidades.Clases;
using Base.Domain.Entidades.Core;
using Base.Domain.Entidades.Escuela;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
namespace Base.Domain.DTOs.Personas
{
    public class AlumnoEntityDTO : BaseDTO
    {
        public int Matricula { get; set; }
        public string ContactoEmergencia { get; set; }
        public string NecesidadesEspeciales { get; set; }
        public DateTime FechaIngreso { get; set; }
        public int IdPersona { get; set; }
        public int IdCursoEscolar { get; set; }
    }
}
