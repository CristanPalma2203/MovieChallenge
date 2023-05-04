using Dominio.Models;
using Dominio.Repositories;
using Infraestructura.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infraestructura.Repositories
{
    public class UsuarioRolRepository : GenericRepository<UsuarioRol>, IUsuarioRolRepository
    {
        private readonly MovieContext dbContext;

        public UsuarioRolRepository(MovieContext dbContext) : base(dbContext)
        {
            this.dbContext = dbContext;
        }

        public IEnumerable<UsuarioRol> FilterWithDetalle(Func<UsuarioRol, bool> predicate)
        {
            var resultado = dbContext.Set<UsuarioRol>().AsNoTracking().Include("Usuario").Where(predicate);

            return resultado;
        }
    }
}
