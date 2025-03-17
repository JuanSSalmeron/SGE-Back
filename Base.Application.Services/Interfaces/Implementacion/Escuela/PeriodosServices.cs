using AutoMapper;
using Base.Application.Services.Interfaces.Contrato.Escuela;
using Base.Domain.DTOs.Escuela;
using Base.Domain.Entidades.Escuela;
using Base.Infraestructura.Data.Repositorios.Contrato.Escuela;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Base.Application.Services.Interfaces.Implementacion.Escuela
{
    public class PeriodosServices : ServiceBase<PeriodosEntity, PeriodosEntityDTO>, IPeriodosServices
    {
        private readonly IPeriodosRepository _periodosRepository;
        public PeriodosServices(IMapper mapper, IPeriodosRepository periodosRepository) : base(mapper, periodosRepository)
        {
            _periodosRepository = periodosRepository;
        }
    }
}
