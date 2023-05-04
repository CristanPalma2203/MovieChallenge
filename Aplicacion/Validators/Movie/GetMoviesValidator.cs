using Aplicacion.Commands.Movie;
using Aplicacion.Services.Validaciones;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aplicacion.Validators.Movie
{
    class GetMoviesValidator : Validador<GetMovies>
    {
        public GetMoviesValidator(IAutenticationHelper autenticationHelper) : base(autenticationHelper)
        {

        }
        public override IList<string> Permisos => new List<string>();
    }
}
