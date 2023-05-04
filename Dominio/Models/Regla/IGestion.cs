using Dominio.Especifications;
using Dominio.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Dominio.Models.Regla
{
    public interface IGestionado : IRegla
    {
        bool Gestionado (int IdRecibo);
    }
    public class EntidadGestionado : IGestionado
    {
        private readonly IMovieRepository movieRepository;

        public EntidadGestionado(IMovieRepository movieRepository)
        {
            this.movieRepository = movieRepository;
        }
        public bool Gestionado(int IdRecibo)
        {
            var recibos = movieRepository.Filter(new SearchMovieById(IdRecibo)).Count();
            return recibos == 0;
        }
    }
}
