using AutoMapper;
using Base.Domain.DTO.Core;
using Base.Domain.DTOs.Clases;
using Base.Domain.DTOs.Escuela;
using Base.Domain.DTOs.Personas;
using Base.Domain.Entidades.Clases;
using Base.Domain.Entidades.Core;
using Base.Domain.Entidades.Escuela;
using Base.Domain.Entidades.Personas;

namespace Base.Application.Services.Mapeo
{
    public class DomainToDtoMappingProfile : Profile
    {
        public DomainToDtoMappingProfile()
        {
            this.CreateMap<BaseEntity, BaseDTO>();

            // Mapeo de Personas.
            this.CreateMap<AlumnoEntity, AlumnoEntityDTO>();
            this.CreateMap<PersonaEntity, PersonaEntityDTO>();
            this.CreateMap<ProfesorEntity, ProfesorEntityDTO>();

            // Mapeo de Escuela.
            this.CreateMap<CursoEscolarEntity, CursoEscolarEntityDTO>();
            this.CreateMap<CalificacionesEntity, CalificacionesEntityDTO>();
            this.CreateMap<PeriodosEntity, PeriodosEntityDTO>();

            // Mapeo de Clases.
            this.CreateMap<ClasesEntity, ClasesEntityDTO>();
            this.CreateMap<GruposAlumnosEntity, GruposAlumnosEntityDTO>();
            this.CreateMap<GruposEntity, GruposEntityDTO>();
            this.CreateMap<GruposPeriodosEntity, GruposPeriodosEntityDTO>();
            this.CreateMap<MateriaGrupoEntity, MateriaGrupoEntityDTO>();
            this.CreateMap<MateriasEntity, MateriasEntityDTO>();
            this.CreateMap<UnidadesEntity, UnidadesEntityDTO>();
        }
    }
}
