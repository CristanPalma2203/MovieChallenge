using System;
using System.Collections.Generic;
using System.Linq;
using AutoMapper;
using System.Text;
using System.Threading.Tasks;
using Dominio.Models;
using Dominio.Repositories.Extensions;
using Aplicacion.Dtos;

namespace Aplicacion.Mappers
{
    public class DtoRatingMovieToRatingMovie : Profile
    {
        public DtoRatingMovieToRatingMovie()
        {
            CreateMap<RatingMovieDto, RatingMovie>();
            CreateMap<RatingMovie, RatingMovieDto>();
        }
    }
}
