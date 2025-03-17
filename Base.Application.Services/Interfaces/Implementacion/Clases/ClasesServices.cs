using AutoMapper;
using Base.Application.Services.Interfaces.Contrato.Clases;
using Base.Domain.DTOs.Clases;
using Base.Domain.Entidades.Clases;
using Base.Infraestructura.Data.Repositorios.Contrato.Clases;

namespace Base.Application.Services.Interfaces.Implementacion.Clases
{
    public class ClasesServices : ServiceBase<ClasesEntity, ClasesEntityDTO>, IClasesServices
    {
        private readonly IClasesRepository _clasesRepository;
        public ClasesServices(IMapper mapper, IClasesRepository clasesRepository) : base(mapper, clasesRepository)
        {
            _clasesRepository = clasesRepository;
        }
    }
}
