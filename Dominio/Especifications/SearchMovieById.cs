using Dominio.Models;
using System;
using System.Collections.Generic;
using System.Text;


namespace Dominio.Especifications
{
    public class SearchMovieById : ISpecification<Movie>
    {
        private readonly int idMovie;

        public SearchMovieById(int idMovie)
        {
            this.idMovie = idMovie;
        }
        public Func<Movie, bool> Traer()
        {
            var x = new Func<Movie, bool>(c => c.Id == idMovie);
            return x;
        }
    }
}
