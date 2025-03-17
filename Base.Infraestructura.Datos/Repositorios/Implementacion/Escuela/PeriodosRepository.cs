using Base.Domain.Entidades.Escuela;
using Base.Infraestructura.Data.Repositories.Implementation;
using Base.Infraestructura.Data.Repositorios.Contrato.Escuela;
using Base.Infraestructura.Datos.ContextoBD;
using System.Security.Claims;

namespace Base.Infraestructura.Data.Repositorios.Implementacion.Escuela
{
    public class PeriodosRepository : BaseRepository<PeriodosEntity>, IPeriodosRepository
    {
        private readonly DataBaseContext _context;
        public PeriodosRepository(DataBaseContext context, ClaimsPrincipal user) : base(context, user)
        {
            _context = context;
        }
    }
}
