using Aplicacion.Commands.Movie;
using Aplicacion.Dtos;
using AutoMapper;
using Dominio.Especifications;
using Dominio.Models;
using Dominio.Repositories;
using Dominio.Services;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aplicacion.CommandHandlers.Movie
{
    public class GetAllRatingMoviesHandler : AbstractHandler<GetAllRatingMovies>
    {
        private readonly IMapper mapper;
        private readonly ITokenService tokenService;
        private readonly IRatingMovieRepository ratemovieRepository;
        public GetAllRatingMoviesHandler(IMapper mapper, ITokenService tokenService, IRatingMovieRepository ratemovieRepository)
        {
            this.mapper = mapper;
            this.tokenService = tokenService;
            this.ratemovieRepository = ratemovieRepository; 
        }

        public override IResponse Handle(GetAllRatingMovies message)
        {
            var idUsuario = tokenService.GetIdUsuario();
            ListRatingsMovie response = new ListRatingsMovie();
            response.Entity = ratemovieRepository.GetAll()
                                     .Include(r => r.Movie)
                                     .Where(r => r.UsuarioId == idUsuario)
                                     .ToList();
            return response;
        }
    }
}
