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
    public class MovieDtoToMovie : Profile
    {
        public MovieDtoToMovie()
        {


            CreateMap<MovieDto, Movie>();
            CreateMap<Movie, MovieDto>().ForMember(c => c.MovieRating, f => f.MapFrom(c => GetRating(c)));

            CreateMap<IPagina<Movie>, DtoMoviesPaginados>().ForMember(c => c.Metadata, f => f.MapFrom(c => Getmetadata(c)))
                        .ForMember(c => c.valores, f => f.MapFrom((g, orderDto, i, context) => GetList(g, context)));
        }
        public IList<MovieDto> GetList(IList<Movie> servicios, ResolutionContext context)
        {
            var respuesta = new List<MovieDto>();
            foreach (var servicio in servicios) {
                var count = 0;
                var sumRate = 0;
                var resp = context.Mapper.Map<MovieDto>(servicio);
                if (servicio.MoviesRating.Count != 0) {
                    foreach (var item in servicio.MoviesRating)
                    {
                        sumRate += item.Rating;
                        count++;
                    }
                    resp.GlobalRate = sumRate / count;
                    
                }
                respuesta.Add(resp);

            }
           
            return respuesta;
        }

        private List<RatingMovieDto> GetRating(Movie movie)
        {
            var lista = new List<RatingMovieDto>();

            if (movie.MoviesRating != null)
            {
                foreach (var rating in movie.MoviesRating)
                {
                    lista.Add(new RatingMovieDto
                    {
                        Id = rating.Id,
                        Rating = rating.Rating,
                        UsuarioId = rating.UsuarioId,
                        MovieId = rating.MovieId
                    });
                }
            }
            return lista;
        }

        private Metadata Getmetadata<T>(IPagina<T> paging) {
            var metada = new Metadata
            {
                CurrentPage = paging.CurrentPage,
                PageSize = paging.PageSize,
                TotalCount = paging.TotalCount,
                TotalPages = paging.TotalPages,
            };
            return metada;
        }
    }
}
