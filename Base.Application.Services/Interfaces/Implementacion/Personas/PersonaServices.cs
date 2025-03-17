using AutoMapper;
using Base.Application.Services.Interfaces.Contrato.Personas;
using Base.Domain.DTOs.Personas;
using Base.Domain.Entidades.Personas;
using Base.Infraestructura.Data.Repositorios.Contrato;
using Base.Infraestructura.Data.Repositorios.Contrato.Personas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Base.Application.Services.Interfaces.Implementacion.Personas
{
    public class PersonaServices : ServiceBase<PersonaEntity, PersonaEntityDTO>, IPersonaServices
    {
        private readonly IPersonaRepository _personaRepository;
        public PersonaServices(IMapper mapper, IPersonaRepository personaRepository) : base(mapper, personaRepository)
        {
            _personaRepository = personaRepository;
        }
    }
}
