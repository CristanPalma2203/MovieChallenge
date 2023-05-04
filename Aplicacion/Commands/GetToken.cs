using Dominio.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aplicacion.Commands
{
    public class GetToken : IMessage
    {
        public string usuario { get; set; }
        public string password { get; set; }
    }
}
