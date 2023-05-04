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
    public class UpdateMovieHandler : AbstractHandler<UpdateMovie>
    {
        private readonly IMovieRepository movieRepository;
        private readonly IMapper mapper;
        private readonly ITokenService tokenService;


        public UpdateMovieHandler(IMovieRepository movieRepository, IMapper mapper, ITokenService tokenService)
        {
            this.movieRepository = movieRepository;
            this.mapper = mapper;
            this.tokenService = tokenService;
        }

        public override IResponse Handle(UpdateMovie message)
        {
            var movieOld = movieRepository.GetById(message.Movie.Id);
            var movieNew = mapper.Map<Dominio.Models.Movie>(message.Movie);
            movieNew.CreatedByUserId = tokenService.GetIdUsuario();
            movieRepository.Update(movieOld.Id, movieNew);
            return new OkResponse();
        }
    }
}
