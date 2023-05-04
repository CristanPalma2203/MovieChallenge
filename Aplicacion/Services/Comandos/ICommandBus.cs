using Aplicacion.Dtos;
using Dominio.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aplicacion.Services.Comandos
{
    public interface ICommandBus
    {
        IResponse execute(IMessage comando);
    }
}
