using Dominio.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio.Repositories
{
    public interface IRolRepository : IGenericRepository<Rol>
    {
        Rol GetByIdConPermisos(int id);
    }
}
