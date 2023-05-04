using Dominio.Models;
using Dominio.Repositories.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio.Repositories
{
    public interface IMovieRepository : IGenericRepository<Movie>
    {
        List<KeyValuePair<int?, int>> GetCountRecibosPorUsuarioAsignado();
    }
}
