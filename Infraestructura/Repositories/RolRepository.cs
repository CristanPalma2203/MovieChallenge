using Dominio.Models;
using Dominio.Repositories;
using Infraestructura.Data;
using System.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Microsoft.EntityFrameworkCore;

namespace Infraestructura.Repositories
{
    public class RolRepository : GenericRepository<Rol>, IRolRepository
    {
        private readonly MovieContext dbContext;

        public RolRepository(MovieContext dbContext) : base(dbContext)
        {
            this.dbContext = dbContext;
        }



        public Rol GetByIdConPermisos(int id)
        {
            return dbContext.Set<Rol>().AsNoTracking().Include(c => c.Permisos).FirstOrDefault(e => e.Id == id); ;
        }
    }
}
