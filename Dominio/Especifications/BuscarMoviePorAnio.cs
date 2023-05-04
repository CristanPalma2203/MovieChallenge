using Ardalis.Specification;
using Dominio.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Dominio.Especifications
{
    public class BuscarMoviePorAnio : Specification<Movie>
    {
        public BuscarMoviePorAnio(int? anio)
        {
            if (anio != 0)
            {
                Query.Where(c => c.ReleaseYear == anio);
            }
        }
    }
}
