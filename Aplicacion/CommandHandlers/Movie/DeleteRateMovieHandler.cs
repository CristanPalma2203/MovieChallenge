using Aplicacion.Commands;
using Aplicacion.Commands.Movie;
using Aplicacion.Dtos;
using AutoMapper;
using Dominio.Especifications;
using Dominio.Models;
using Dominio.Repositories;
using Dominio.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aplicacion.CommandHandlers.Movie
{
    public class DeleteRateMovieHandler : AbstractHandler<DeleteRateMovie>
    {
        private readonly IRatingMovieRepository ratingMovie;
        private readonly ITokenService tokenService;

        public DeleteRateMovieHandler(IRatingMovieRepository ratingMovie, ITokenService tokenService)
        {
            this.ratingMovie = ratingMovie;
            this.tokenService = tokenService;
        }

        public override IResponse Handle(DeleteRateMovie message)
        {
            var idUsuario = tokenService.GetIdUsuario();
            var rate = ratingMovie.Filter(new BuscarRateMoviePorUsuario(message.IdMovie, idUsuario)).FirstOrDefault();
            ratingMovie.Delete(rate.Id);
            return new OkResponse();
        }
    }
}
