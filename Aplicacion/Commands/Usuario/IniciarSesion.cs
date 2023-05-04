using Dominio.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aplicacion.Commands.Usuario
{
    public class IniciarSesion : IMessage
    {
        public string Usuario { get; set; }
        public string Contrasena { get; set; }

    }
}
