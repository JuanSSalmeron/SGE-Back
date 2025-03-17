using Base.API.Controllers;
using Base.Application.Services.Interfaces.Contrato.Clases;
using Base.Domain.DTOs.Clases;
using Base.Domain.Entidades.Clases;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Backend_Base.Controllers.Clases
{
    [Route("api/[controller]")]
    [ApiController]
    public class UnidadesController : APIControllerBase<UnidadesEntity, UnidadesEntityDTO>
    {
        private readonly IUnidadesServices _unidadesServices;
        public UnidadesController(IUnidadesServices unidadesServices) : base(unidadesServices)
        {
            _unidadesServices = unidadesServices;
        }
    }
}
