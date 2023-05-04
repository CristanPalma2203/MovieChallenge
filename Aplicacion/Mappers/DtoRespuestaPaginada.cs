using Aplicacion.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aplicacion.Mappers
{
    public class DtoRespuestaPaginada<T> : IResponse
    {
        public IEnumerable<T> valores { get; set; }
        public Metadata Metadata { get; set; }
    }
}
