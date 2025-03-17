using Base.Domain.Entidades.Personas;
using Base.Infraestructura.Data.Repositories.Implementation;
using Base.Infraestructura.Data.Repositorios.Contrato.Personas;
using Base.Infraestructura.Datos.ContextoBD;
using System.Security.Claims;

namespace Base.Infraestructura.Data.Repositorios.Implementacion.Personas
{
    public class AlumnoRepository : BaseRepository<AlumnoEntity>, IAlumnoRepository
    {
        private readonly DataBaseContext _context;
        public AlumnoRepository(DataBaseContext context, ClaimsPrincipal user) : base(context, user)
        {
            _context = context;
        }
    }
}
