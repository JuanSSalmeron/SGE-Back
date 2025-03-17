using Base.API.Controllers;
using Base.Application.Services.Interfaces.Contrato;
using Base.Application.Services.Interfaces.Contrato.Personas;
using Base.Domain.DTOs.Personas;
using Base.Domain.Entidades.Personas;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Backend_Base.Controllers.Personas
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProfesorController : APIControllerBase<ProfesorEntity, ProfesorEntityDTO>
    {
        private readonly IProfesorServices _profesorServices;
        public ProfesorController(IProfesorServices profesorServices) : base(profesorServices)
        {
            _profesorServices = profesorServices;
        }
    }
}
