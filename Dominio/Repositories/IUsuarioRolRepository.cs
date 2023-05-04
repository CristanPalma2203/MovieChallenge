using Dominio.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio.Repositories
{
    public interface IUsuarioRolRepository : IGenericRepository<UsuarioRol>
    {
        IEnumerable<UsuarioRol> FilterWithDetalle(Func<UsuarioRol, bool> predicate);
    }
}
