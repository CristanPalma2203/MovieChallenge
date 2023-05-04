using Dominio.Models;
using Dominio.Services;
using Infraestructura.Seeders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infraestructura.Data
{
    public class MovieContext : DbContext
    {
        private readonly ITokenService tokenService;
        public MovieContext(DbContextOptions<MovieContext> options, ITokenService tokenService)
      : base(options)
        {
            this.ChangeTracker.LazyLoadingEnabled = false;
            this.tokenService = tokenService;
        }

        public DbSet<Movie> Movie { get; set; }
        public DbSet<Usuario> Usuario { get; set; }
        public DbSet<UsuarioRol> UsuarioRol { get; set; }
        public DbSet<Rol> Rol { get; set; }
        public DbSet<RolPermiso> RolPermiso { get; set; }
        public DbSet<Permiso> Permiso { get; set; }
        public DbSet<RatingMovie> RatingMovie { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            RolPermisoSeeder.Seed(builder);
            UsuarioSeeder.Seed(builder);
            MovieSeeder.Seed(builder);
            
            builder.ApplyConfigurationsFromAssembly(typeof(MovieContext).Assembly);
            base.OnModelCreating(builder);

        }

        public override int SaveChanges()
        {
            var changedEntities = ChangeTracker.Entries();


            return base.SaveChanges();
        }

    }
}
