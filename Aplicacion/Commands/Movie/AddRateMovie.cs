using Aplicacion.Dtos;
using Dominio.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aplicacion.Commands.Movie
{
    public class AddRateMovie : IMessage
    {
        public RatingMovieDto RatingMovieDto { get; set; }
    }
}
