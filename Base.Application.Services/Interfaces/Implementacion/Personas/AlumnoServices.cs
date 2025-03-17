using AutoMapper;
using Base.Application.Services.Interfaces.Contrato;
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
    public class AlumnoServices : ServiceBase<AlumnoEntity, AlumnoEntityDTO>, IAlumnoServices
    {
        private readonly IAlumnoRepository _alumnoRepository;
        public AlumnoServices(IMapper mapper, IAlumnoRepository alumnoRepository) : base(mapper, alumnoRepository)
        {
            _alumnoRepository = alumnoRepository;
        }
    }
}
