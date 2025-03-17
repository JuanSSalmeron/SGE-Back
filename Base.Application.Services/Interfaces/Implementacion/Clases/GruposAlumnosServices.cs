using AutoMapper;
using Base.Application.Services.Interfaces.Contrato.Clases;
using Base.Domain.DTOs.Clases;
using Base.Domain.Entidades.Clases;
using Base.Infraestructura.Data.Repositorios.Contrato.Clases;

namespace Base.Application.Services.Interfaces.Implementacion.Clases
{
    public class GruposAlumnosServices : ServiceBase<GruposAlumnosEntity, GruposAlumnosEntityDTO>, IGruposAlumnosServices
    {
        private readonly IGruposAlumnosRepository _gruposAlumnosRepository;
        public GruposAlumnosServices(IMapper mapper, IGruposAlumnosRepository gruposAlumnosRepository) : base(mapper, gruposAlumnosRepository)
        {
            _gruposAlumnosRepository = gruposAlumnosRepository;
        }
    }
}
