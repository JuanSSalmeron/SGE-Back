using Base.API.Controllers;
using Base.Application.Services.Interfaces.Contrato.Personas;
using Base.Domain.DTOs.Personas;
using Base.Domain.Entidades.Personas;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Backend_Base.Controllers.Personas
{
    [Route("api/[controller]")]
    [ApiController]
    public class AlumnoController : APIControllerBase<AlumnoEntity, AlumnoEntityDTO>
    {
        private readonly IAlumnoServices _alumnoServices;
        public AlumnoController(IAlumnoServices alumnoServices) : base(alumnoServices)
        {
            _alumnoServices = alumnoServices;
        }
    }
}
