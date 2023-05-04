using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aplicacion.Dtos
{
    public class ListRatingsMovie : IResponse
    {
        public ListRatingsMovie()
        {

        }
        public List<Dominio.Models.RatingMovie> Entity { get; set; }

    }
}
