using Base.Domain.Entidades.Personas;
using Base.Infraestructura.Data.Repositories.Implementation;
using Base.Infraestructura.Data.Repositorios.Contrato.Personas;
using Base.Infraestructura.Datos.ContextoBD;
using System.Security.Claims;

namespace Base.Infraestructura.Data.Repositorios.Implementacion.Personas
{
    public class ProfesorRepository : BaseRepository<ProfesorEntity>, IProfesorRepository
    {
        private readonly DataBaseContext _context;
        public ProfesorRepository(DataBaseContext context, ClaimsPrincipal user) : base(context, user)
        {
            _context = context;
        }
    }
}
