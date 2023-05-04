using Aplicacion.Commands.Movie;
using Aplicacion.Services.Validaciones;
using Dominio.Especifications;
using Dominio.Models;
using Dominio.Repositories;
using Dominio.Services;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aplicacion.Validators.Movie
{
    public class DeleteRateMovieValidator : Validador<DeleteRateMovie>
    {
        private readonly ITokenService tokenService;
        private readonly IRatingMovieRepository ratingMovie;
        public DeleteRateMovieValidator(IAutenticationHelper autenticationHelper, ITokenService tokenService, IRatingMovieRepository ratingMovie) : base(autenticationHelper)
        {
            this.tokenService = tokenService;
            this.ratingMovie = ratingMovie;

            RuleFor(x => x.IdMovie).NotEmpty().Must(c => ValidarUsuarioMovieRate(c)).WithMessage("No puedes eliminar calificaciones de otros usuarios");
        }

        private bool ValidarUsuarioMovieRate(int idMovie)
        {
            var idUsuario = tokenService.GetIdUsuario();
            var usuario = ratingMovie.Filter(new BuscarRateMoviePorUsuario(idMovie, idUsuario));
            return usuario.Count() > 0;

        }
        public override IList<string> Permisos => new List<string> { "movie", "movie-eliminar", "administracion" };
    }
}
