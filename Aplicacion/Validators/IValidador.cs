using Dominio.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aplicacion.Validators
{
    public interface IValidador
    {
        void VerificarUsuario();
        void ValidarComando(IMessage comando);
        void Validar(IMessage comando);
        IList<string> Permisos { get; }
    }
}
