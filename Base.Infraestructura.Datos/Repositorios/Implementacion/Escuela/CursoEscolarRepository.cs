using Base.Domain.Entidades.Escuela;
using Base.Infraestructura.Data.Repositories.Implementation;
using Base.Infraestructura.Data.Repositorios.Contrato.Escuela;
using Base.Infraestructura.Datos.ContextoBD;
using System.Security.Claims;

namespace Base.Infraestructura.Data.Repositorios.Implementacion.Escuela
{
    public class CursoEscolarRepository : BaseRepository<CursoEscolarEntity>, ICursoEscolarRepository
    {
        private readonly DataBaseContext _context;
        public CursoEscolarRepository(DataBaseContext context, ClaimsPrincipal user) : base(context, user)
        {
            _context = context;
        }
    }
}
