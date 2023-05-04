using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aplicacion.Dtos.Rol
{
    public class DtoPermiso
    {
        public int Id { get; set; }

        public string Codigo { get; set; }
        public string Nombre { get; set; }
        public int? PermisoPadre { get; set; }
        public IEnumerable<DtoPermiso> Hijos { get; set; }
    }
}
