using Dominio.Especifications;
using Dominio.Models;
using Dominio.Repositories.Extensions;
using System;
using System.Collections.Generic;
using System.Text;

namespace Dominio.Repositories
{
    public interface IUsuarioRepository : IGenericRepository<Usuario>
    {
        Usuario GetUsuarioConRolPermiso(ISpecification<Usuario> busqueda);
    }
}
