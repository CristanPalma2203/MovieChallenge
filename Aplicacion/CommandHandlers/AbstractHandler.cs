using Aplicacion.Dtos;
using Aplicacion.Services.Comandos;
using Dominio.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aplicacion.CommandHandlers
{
    public abstract class AbstractHandler<T> : ICommandHandler<T> where T : IMessage
    {
        public abstract IResponse Handle(T message);


        public IResponse ejecutar(IMessage message)
        {
            return Handle((T)message);
        }
    }
}
