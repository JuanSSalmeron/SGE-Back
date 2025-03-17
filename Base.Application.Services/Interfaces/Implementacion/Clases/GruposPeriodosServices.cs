using AutoMapper;
using Base.Application.Services.Interfaces.Contrato.Clases;
using Base.Domain.DTOs.Clases;
using Base.Domain.Entidades.Clases;
using Base.Infraestructura.Data.Repositorios.Contrato.Clases;

namespace Base.Application.Services.Interfaces.Implementacion.Clases
{
    public class GruposPeriodosServices : ServiceBase<GruposPeriodosEntity, GruposPeriodosEntityDTO>, IGruposPeriodosServices
    {
        private readonly IGruposPeriodosRepository _gruposPeriodosRepository;
        public GruposPeriodosServices(IMapper mapper, IGruposPeriodosRepository gruposPeriodosRepository) : base(mapper, gruposPeriodosRepository)
        {
            _gruposPeriodosRepository = gruposPeriodosRepository;
        }
    }
}
