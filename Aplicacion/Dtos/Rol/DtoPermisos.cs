using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aplicacion.Dtos.Rol
{
    public class DtoPermisos : IResponse
    {
        public IEnumerable<DtoPermiso> Permisos { get; set; }
    }
}
