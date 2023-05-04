using Aplicacion.Commands.Movie;
using Aplicacion.Dtos;
using AutoMapper;
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
    public class CreateMovieHandler : AbstractHandler<CreateMovie>
    {
        private readonly IMovieRepository movieRepository;
        private readonly IMapper mapper;
        private readonly ITokenService tokenService;

        public CreateMovieHandler(IMovieRepository movieRepository, IMapper mapper, ITokenService tokenService)
        {
            this.movieRepository = movieRepository;
            this.mapper = mapper;
            this.tokenService = tokenService;
        }

        public override IResponse Handle(CreateMovie message)
        {
            var movie = mapper.Map<Dominio.Models.Movie>(message.Movie);
            movie.CreatedByUserId = tokenService.GetIdUsuario();
            movie.CreatedDate = DateTime.Now;
            movieRepository.Create(movie);
            return new OkResponse();
        }
    }
}
