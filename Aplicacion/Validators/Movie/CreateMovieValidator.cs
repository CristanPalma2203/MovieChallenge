using System.Collections.Generic;
using System.Linq;
using Aplicacion.Commands.Movie;
using Aplicacion.Services.Validaciones;
using Dominio.Repositories;
using Dominio.Services;
using FluentValidation;

namespace Aplicacion.Validators.Movie
{
    public class CreateMovieValidator : Validador<CreateMovie>
    {
        private readonly ITokenService tokenService;

        public CreateMovieValidator(IAutenticationHelper autenticationHelper, ITokenService tokenService) : base(autenticationHelper)
        {

            this.tokenService = tokenService;

            RuleFor(x => x.Movie.Name).NotEmpty();


        }
        public override IList<string> Permisos => new List<string> { "administracion" };
    }
}
