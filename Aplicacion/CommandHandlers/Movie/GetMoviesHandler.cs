using Aplicacion.Dtos;
using Dominio.Models;
using AutoMapper;
using Dominio.Especifications;
using Dominio.Repositories;
using Dominio.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Dynamic;
using Microsoft.Extensions.Configuration;
using Aplicacion.Commands.Movie;
using Aplicacion.Mappers;

namespace Aplicacion.CommandHandlers.Movie
{
    public class GetMoviesHandler : AbstractHandler<GetMovies>
    {
        private readonly IMovieRepository movieRepository;
        private readonly IMapper mapper;
        private readonly ITokenService tokeService;
        public GetMoviesHandler(IMapper mapper, ITokenService tokeService, IMovieRepository movieRepository)
        {
            this.mapper = mapper;
            this.tokeService = tokeService;
            this.movieRepository = movieRepository;
        }

        public override IResponse Handle(GetMovies message)
        {
            var include = new Includes<Dominio.Models.Movie>(new[] { "MoviesRating" });
            var respuesta = movieRepository.Specify(include)
                .Specify(new BuscarMoviesPorNombreOSinopsis(message.NameOrSypnosis))
                .Specify(new BuscarMoviePorCategoria(message.Category))
                .Specify(new BuscarMoviePorAnio(message.Year))
                .Specify(new OrdenarPorSpecificacion(message.OrderBy))
                .Paginar(message);
            return mapper.Map<DtoMoviesPaginados>(respuesta);
        }
    }
}
