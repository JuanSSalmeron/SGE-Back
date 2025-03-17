using AutoMapper;
using Base.Application.Services.Interfaces.Contrato.Personas;
using Base.Domain.DTOs.Personas;
using Base.Domain.Entidades.Personas;
using Base.Infraestructura.Data.Repositorios.Contrato.Personas;

namespace Base.Application.Services.Interfaces.Implementacion.Personas
{
    public class ProfesorServices : ServiceBase<ProfesorEntity, ProfesorEntityDTO>, IProfesorServices
    {
        private readonly IProfesorRepository _profesorRepository;
        public ProfesorServices(IMapper mapper, IProfesorRepository profesorRepository) : base(mapper, profesorRepository)
        {
            _profesorRepository = profesorRepository;
        }
    }
}
