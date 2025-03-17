using AutoMapper;
using Base.Application.Services.Interfaces.Contrato.Clases;
using Base.Domain.DTOs.Clases;
using Base.Domain.Entidades.Clases;
using Base.Infraestructura.Data.Repositorios.Contrato.Clases;

namespace Base.Application.Services.Interfaces.Implementacion.Clases
{
    public class MateriaGrupoServices : ServiceBase<MateriaGrupoEntity, MateriaGrupoEntityDTO>, IMateriaGrupoServices
    {
        private readonly IMateriaGrupoRepository _materiaGrupoRepository;
        public MateriaGrupoServices(IMapper mapper, IMateriaGrupoRepository materiaGrupoRepository) : base(mapper, materiaGrupoRepository)
        {
            _materiaGrupoRepository = materiaGrupoRepository;
        }
    }
}
