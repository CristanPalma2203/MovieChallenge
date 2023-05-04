using Aplicacion.Commands.Movie;
using Aplicacion.Dtos;
using AutoMapper;
using Dominio.Repositories;
using Dominio.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aplicacion.CommandHandlers.Movie
{
    public class AddRateMovieHandler : AbstractHandler<AddRateMovie>
    {
        private readonly IRatingMovieRepository ratemovieRepository;
        private readonly IMapper mapper;
        private readonly ITokenService tokenService;

        public AddRateMovieHandler(IRatingMovieRepository ratemovieRepository, IMapper mapper, ITokenService tokenService)
        {
            this.ratemovieRepository = ratemovieRepository;
            this.mapper = mapper;
            this.tokenService = tokenService;
        }

        public override IResponse Handle(AddRateMovie message)
        {
            var rateMovie = mapper.Map<Dominio.Models.RatingMovie>(message.RatingMovieDto);
            rateMovie.UsuarioId = tokenService.GetIdUsuario();
            ratemovieRepository.Create(rateMovie);
            return new OkResponse();
        }
    }
}
