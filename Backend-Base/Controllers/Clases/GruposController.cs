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
    public class GruposController : APIControllerBase<GruposEntity, GruposEntityDTO>
    {
        private readonly IGruposServices _gruposServices;
        public GruposController(IGruposServices gruposServices) : base(gruposServices)
        {
            _gruposServices = gruposServices;
        }
    }
}
