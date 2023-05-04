
using Dominio.Models;
using Dominio.Repositories;
using Dominio.Repositories.Extensions;
using Infraestructura.Data;
using Infraestructura.Repositories.Extensions;
using Microsoft.EntityFrameworkCore;
using System.Linq.Dynamic.Core;
using Microsoft.Extensions.Configuration;


namespace Infraestructura.Repositories
{
    public class MovieRepository : GenericRepository<Movie>, IMovieRepository
    {
        private readonly MovieContext dbContext;
        private readonly IConfiguration configuration;

        public MovieRepository(MovieContext dbContext, IConfiguration configuration) : base(dbContext)
        {
            this.dbContext = dbContext;
            this.configuration = configuration;
        }

        

        public List<KeyValuePair<int?, int>> GetCountRecibosPorUsuarioAsignado()
        {
            return dbContext.Set<Movie>()
                      .GroupBy(p => p.CreatedByUserId)
                      .Select(g => new KeyValuePair<int?, int>(g.Key, g.Count())).ToList();
        }




    }
}
