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
    public class MateriaGrupoController : APIControllerBase<MateriaGrupoEntity, MateriaGrupoEntityDTO>
    {
        private readonly IMateriaGrupoServices _materiaGrupoServices;
        public MateriaGrupoController(IMateriaGrupoServices materiaGrupoServices) : base(materiaGrupoServices)
        {
            _materiaGrupoServices = materiaGrupoServices;
        }
    }
}
