using Base.Domain.DTOs.Personas;
using Base.Domain.Entidades.Personas;
using Base.Domain.ViewModels;

namespace Base.Application.Services.Interfaces.Contrato.Personas
{
    public interface IAlumnoServices : IServiceBase<AlumnoEntity, AlumnoEntityDTO>
    {
        Task<ResponseHelper> GetAlumnosDatosCompletos();
        Task<ResponseHelper> GetAlumnoDatosCompletos(int id);
    }
}
