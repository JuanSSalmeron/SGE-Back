using AutoMapper;
using Base.Application.Services.Interfaces.Contrato.Clases;
using Base.Domain.DTOs.Clases;
using Base.Domain.Entidades.Clases;
using Base.Infraestructura.Data.Repositorios.Contrato.Clases;

namespace Base.Application.Services.Interfaces.Implementacion.Clases
{
    public class GruposServices : ServiceBase<GruposEntity, GruposEntityDTO>, IGruposServices
    {
        private readonly IGruposRepository _gruposRepository;
        public GruposServices(IMapper mapper, IGruposRepository gruposRepository) : base(mapper, gruposRepository)
        {
            _gruposRepository = gruposRepository;
        }
    }
}
