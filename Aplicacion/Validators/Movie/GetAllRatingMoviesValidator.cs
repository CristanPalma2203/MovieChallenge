using Aplicacion.Commands.Movie;
using Aplicacion.Services.Validaciones;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aplicacion.Validators.Movie
{
    public class GetAllRatingMoviesValidator : Validador<GetAllRatingMovies>
    {
        public GetAllRatingMoviesValidator(IAutenticationHelper autenticationHelper) : base(autenticationHelper)
        {

        }
        public override IList<string> Permisos => new List<string> { "movie", "administracion" };
    }
}
