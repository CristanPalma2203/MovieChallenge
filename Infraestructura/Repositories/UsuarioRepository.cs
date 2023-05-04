using Dominio.Especifications;
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
    public class UsuarioRepository : GenericRepository<Usuario>, IUsuarioRepository
    {
        private readonly MovieContext dbContext;
        public UsuarioRepository(MovieContext dbContext) : base(dbContext)
        {
            this.dbContext = dbContext;
        }

        public Usuario GetUsuarioConRolPermiso(ISpecification<Usuario> busqueda)
        {
            return dbContext.Set<Usuario>().AsNoTracking().Include("Roles.Rol.Permisos.Permiso").FirstOrDefault(busqueda.Traer());
        }

    }
}
