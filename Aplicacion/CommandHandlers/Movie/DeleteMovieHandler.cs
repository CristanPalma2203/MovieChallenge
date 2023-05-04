using Aplicacion.Commands;
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
    public class DeleteMovieHandler : AbstractHandler<DeleteMovie>
    {
        private readonly IMovieRepository movieRepository;
        private readonly IMapper mapper;
        private readonly ITokenService tokenService;

        public DeleteMovieHandler(IMovieRepository movieRepository, IMapper mapper, ITokenService tokenService)
        {
            this.movieRepository = movieRepository;
            this.mapper = mapper;
            this.tokenService = tokenService;
        }

        public override IResponse Handle(DeleteMovie message)
        {
            movieRepository.Delete(message.Id);
            return new OkResponse();
        }
    }

}
