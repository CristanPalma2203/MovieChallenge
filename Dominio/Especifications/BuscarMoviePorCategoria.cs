using Ardalis.Specification;
using Dominio.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio.Especifications
{
    public class BuscarMoviePorCategoria : Specification<Movie>
    {
        public BuscarMoviePorCategoria(string categoria)
        {
            if (!String.IsNullOrEmpty(categoria))
            {
                Query.Where(c => c.Category.ToLower().Contains(categoria.ToLower()));
            }
        }
    }
}
