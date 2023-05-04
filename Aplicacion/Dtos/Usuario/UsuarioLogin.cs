using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aplicacion.Dtos.Usuario
{
    class DtoUsuarioLogin : DtoUsuarioBase, IResponse
    {
        public string Token { get; set; }

    }
}
