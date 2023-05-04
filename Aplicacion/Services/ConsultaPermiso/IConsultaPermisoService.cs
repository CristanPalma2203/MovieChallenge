using Aplicacion.Dtos.Rol;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aplicacion.Services.ConsultaPermiso
{
    public interface IConsultaPermisoService
    {
        IEnumerable<DtoPermiso> Estructurar(IEnumerable<DtoPermiso> Permisos);
    }
}
