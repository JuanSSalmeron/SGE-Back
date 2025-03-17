using Base.API.Controllers;
using Base.Application.Services.Interfaces.Contrato.Personas;
using Base.Domain.DTOs.Personas;
using Base.Domain.Entidades.Personas;
using Microsoft.AspNetCore.Mvc;

namespace Backend_Base.Controllers.Personas
{
    [Route("api/[controller]")]
    [ApiController]
    public class PersonaController : APIControllerBase<PersonaEntity, PersonaEntityDTO>
    {
        private readonly IPersonaServices _personaServices;
        public PersonaController(IPersonaServices personaServices) : base(personaServices)
        {
            _personaServices = personaServices;
        }
    }
}
