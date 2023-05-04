using Dominio.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio.Especifications
{
    public class BuscarRateMoviePorUsuario : ISpecification<RatingMovie>
    {
        private readonly int idUsuario;
        private readonly int idMovie;

        public BuscarRateMoviePorUsuario(int idMovie, int idUsuario)
        {
            this.idMovie = idMovie;
            this.idUsuario = idUsuario;
        }
        public Func<RatingMovie, bool> Traer()
        {

            return new Func<RatingMovie, bool>(c => c.UsuarioId == idUsuario && c.MovieId == idMovie);
        }
    }
}
