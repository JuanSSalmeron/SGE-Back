using AutoMapper;
using Base.Application.Services.Interfaces.Contrato.Clases;
using Base.Domain.DTOs.Clases;
using Base.Domain.Entidades.Clases;
using Base.Infraestructura.Data.Repositorios.Contrato;
using Base.Infraestructura.Data.Repositorios.Contrato.Clases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Base.Application.Services.Interfaces.Implementacion.Clases
{
    public class MateriasServices : ServiceBase<MateriasEntity, MateriasEntityDTO>, IMateriasServices
    {
        private readonly IMateriasRepository _materiasRepository;
        public MateriasServices(IMapper mapper, IMateriasRepository materiasRepository) : base(mapper, materiasRepository)
        {
            _materiasRepository = materiasRepository;
        }
    }
}
