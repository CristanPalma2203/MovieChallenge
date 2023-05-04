using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio.Especifications
{
    public interface ISpecification<Entidad>
    {
        Func<Entidad, bool> Traer();
    }
}
