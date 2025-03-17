using Base.Domain.Entidades.Clases;
using Base.Infraestructura.Data.Repositories.Implementation;
using Base.Infraestructura.Data.Repositorios.Contrato.Clases;
using Base.Infraestructura.Datos.ContextoBD;
using System.Security.Claims;

namespace Base.Infraestructura.Data.Repositorios.Implementacion.Clases
{
    public class GruposAlumnosRepository : BaseRepository<GruposAlumnosEntity>, IGruposAlumnosRepository
    {
        private readonly DataBaseContext _context;
        public GruposAlumnosRepository(DataBaseContext context, ClaimsPrincipal user) : base(context, user)
        {
            _context = context;
        }
    }
}
