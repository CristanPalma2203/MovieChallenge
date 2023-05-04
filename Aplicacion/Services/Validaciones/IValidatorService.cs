using Dominio.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aplicacion.Services.Validaciones
{
    public interface IValidatorService
    {
        void AplicarValidador(IMessage message);
    }
}
