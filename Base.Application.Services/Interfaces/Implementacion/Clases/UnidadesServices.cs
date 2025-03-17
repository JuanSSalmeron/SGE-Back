using AutoMapper;
using Base.Application.Services.Interfaces.Contrato.Clases;
using Base.Domain.DTOs.Clases;
using Base.Domain.Entidades.Clases;
using Base.Infraestructura.Data.Repositorios.Contrato.Clases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Base.Application.Services.Interfaces.Implementacion.Clases
{
    public class UnidadesServices : ServiceBase<UnidadesEntity, UnidadesEntityDTO>, IUnidadesServices
    {
        private readonly IUnidadesRepository _unidadesRepository;
        public UnidadesServices(IMapper mapper, IUnidadesRepository unidadesRepository) : base(mapper, unidadesRepository)
        {
            _unidadesRepository = unidadesRepository;
        }
    }
}
