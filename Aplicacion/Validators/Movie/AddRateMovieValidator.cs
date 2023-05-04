using Aplicacion.Commands.Movie;
using Aplicacion.Services.Validaciones;
using Dominio.Especifications;
using Dominio.Repositories;
using Dominio.Services;
using FluentValidation;

namespace Aplicacion.Validators.Movie
{
    public class AddRateMovieValidator : Validador<AddRateMovie>
    {
        private readonly ITokenService tokenService;
        private readonly IRatingMovieRepository ratingMovie;

        public AddRateMovieValidator(IAutenticationHelper autenticationHelper, ITokenService tokenService, IRatingMovieRepository ratingMovie) : base(autenticationHelper)
        {

            this.tokenService = tokenService;
            this.ratingMovie = ratingMovie;

            RuleFor(x => x.RatingMovieDto.MovieId).NotEmpty().Must(c => ValidarUsuarioMovieRate(c)).WithMessage("No puedes calificar mas de una vez");

        }

        private bool ValidarUsuarioMovieRate(int idMovie)
        {
            var idUsuario = tokenService.GetIdUsuario();
            var usuario = ratingMovie.Filter(new BuscarRateMoviePorUsuario(idMovie,idUsuario));
            return usuario.Count() == 0;

        }
        public override IList<string> Permisos => new List<string> { "movie", "administracion" };
    }
}
