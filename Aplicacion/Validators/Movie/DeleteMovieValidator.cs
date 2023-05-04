﻿using Aplicacion.Commands.Movie;
using Aplicacion.Services.Validaciones;
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
    public class DeleteMovieValidator : Validador<DeleteMovie>
    {
        private readonly ITokenService tokenService;
        private readonly IMovieRepository movieRepository;

        public DeleteMovieValidator(IAutenticationHelper autenticationHelper, ITokenService tokenService, IMovieRepository movieRepository) : base(autenticationHelper)
        {
            this.tokenService = tokenService;
            this.movieRepository = movieRepository; 
 
            RuleFor(x => x.Id).NotEmpty().Must(c => ValidarMovie(c)).WithMessage("No existe la pelicula");
        }
        private bool ValidarMovie(int idMovie)
        {
            var usuario = movieRepository.GetById(idMovie);
            return usuario != null;

        }
        public override IList<string> Permisos => new List<string> { "administracion" };
    }
}
