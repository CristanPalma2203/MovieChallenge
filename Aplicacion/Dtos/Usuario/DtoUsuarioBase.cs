using Aplicacion.Dtos.Rol;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aplicacion.Dtos.Usuario
{
    public class DtoUsuarioBase
    {
        public IList<DtoRol>? Roles { get; set; }
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Email { get; set; }
        public string IdentificadorAcceso { get; set; }
        public string TipoUsuario { get; set; }


    }
}
