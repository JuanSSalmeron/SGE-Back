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
    public class ClasesController : APIControllerBase<ClasesEntity, ClasesEntityDTO>
    {
        private readonly IClasesServices _clasesService;
        public ClasesController(IClasesServices clasesService) : base(clasesService)
        {
            _clasesService = clasesService;
        }
    }
}
