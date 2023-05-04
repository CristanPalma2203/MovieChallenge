
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
    public class MovieRatingRepository : GenericRepository<RatingMovie>, IRatingMovieRepository
    {
        private readonly MovieContext dbContext;
        private readonly IConfiguration configuration;
        public MovieRatingRepository(MovieContext dbContext, IConfiguration configuration) : base(dbContext)
        {
            this.dbContext = dbContext;
            this.configuration = configuration;
        }
    }
}
