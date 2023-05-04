using Ardalis.Specification;
using Dominio.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Dominio.Especifications
{
    public class OrdenarPorSpecificacion : Specification<Movie>
    { 
        public OrdenarPorSpecificacion(string specification)
        {
            if (!String.IsNullOrEmpty(specification))
            {

                if (specification.ToLower().Contains("year")) {
                    Query.OrderBy(x=>x.ReleaseYear);
                }
                else if (specification.ToLower().Contains("name"))
                {
                    Query.OrderBy(x => x.Name);
                }
                
                
            }
        }
    }
}
