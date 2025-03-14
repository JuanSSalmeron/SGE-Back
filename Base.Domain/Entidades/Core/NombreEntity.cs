using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Base.Domain.Entidades.Core
{
    public abstract class NombreEntity : BaseEntity
    {
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
    }
}
