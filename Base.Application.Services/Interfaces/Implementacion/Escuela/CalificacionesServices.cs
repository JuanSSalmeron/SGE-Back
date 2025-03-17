using AutoMapper;
using Base.Application.Services.Interfaces.Contrato.Escuela;
using Base.Domain.DTOs.Escuela;
using Base.Domain.Entidades.Escuela;
using Base.Infraestructura.Data.Repositorios.Contrato;
using Base.Infraestructura.Data.Repositorios.Contrato.Escuela;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Base.Application.Services.Interfaces.Implementacion.Escuela
{
    public class CalificacionesServices : ServiceBase<CalificacionesEntity, CalificacionesEntityDTO>, ICalificacionesServices
    {
        private readonly ICalificacionesRepository _calificacionesRepository;
        public CalificacionesServices(IMapper mapper, ICalificacionesRepository calificacionesRepository) : base(mapper, calificacionesRepository)
        {
            _calificacionesRepository = calificacionesRepository;
        }
    }
}
