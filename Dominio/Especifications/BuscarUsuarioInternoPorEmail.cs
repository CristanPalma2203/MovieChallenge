using Dominio.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio.Especifications
{
    public class BuscarUsuarioInternoPorEmail: ISpecification<Usuario>
    {
        private readonly string correo;

        public BuscarUsuarioInternoPorEmail(string correo)
        {
            this.correo = correo;
        }
        public Func<Usuario, bool> Traer()
        {

            return new Func<Usuario, bool>(c => c.IdentificadorAcceso == correo);
        }
    }
}
