using Aplicacion.Dtos.Usuario;
using Dominio.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aplicacion.Commands.Usuario
{
    public class RegistrarUsuario : IMessage
    {
        public DtoUsuario Usuario { get; set; }

        
    }
}
