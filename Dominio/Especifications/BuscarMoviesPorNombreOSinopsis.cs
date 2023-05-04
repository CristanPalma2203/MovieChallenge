using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ardalis.Specification;
using Dominio.Models;



namespace Dominio.Especifications
{
    public class BuscarMoviesPorNombreOSinopsis : Specification<Movie>
    {
        public BuscarMoviesPorNombreOSinopsis(string name)
        {
            if (!String.IsNullOrEmpty(name))
            {
                Query.Where(c => c.Name.ToLower().Contains(name.ToLower()) || c.Synopsis.ToLower().Contains(name.ToLower()));
            }
        }
    }
}
