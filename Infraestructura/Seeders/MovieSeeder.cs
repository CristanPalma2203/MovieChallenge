using Dominio.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infraestructura.Seeders
{
    public class MovieSeeder
    {
        public static void Seed(ModelBuilder builder)
        {
            var movie1 = new Movie
            {
                Id = 1,
                Name = "The Shawshank Redemption",
                ReleaseYear = 1994,
                Synopsis = "Two imprisoned men bond over a number of years, finding solace and eventual redemption through acts of common decency.",
                Category = "Drama",
                CreatedByUserId = 1,
                CreatedDate = DateTime.UtcNow
            };
            var movie2 = new Movie
            {
                Id = 2,
                Name = "The Godfather",
                ReleaseYear = 1972,
                Synopsis = "The aging patriarch of an organized crime dynasty transfers control of his clandestine empire to his reluctant son.",
                Category = "Crime",
                CreatedByUserId = 1,
                CreatedDate = DateTime.UtcNow
            };

            var movie3 = new Movie
            {
                Id = 3,
                Name = "The Dark Knight",
                ReleaseYear = 2008,
                Synopsis = "When the menace known as the Joker wreaks havoc and chaos on the people of Gotham, Batman must accept one of the greatest psychological and physical tests of his ability to fight injustice.",
                Category = "Action",
                CreatedByUserId = 1,
                CreatedDate = DateTime.UtcNow
            };
            var movie4 = new Movie
            {
                Id = 4,
                Name = "Pulp Fiction",
                ReleaseYear = 1994,
                Synopsis = "The lives of two mob hitmen, a boxer, a gangster and his wife, and a pair of diner bandits intertwine in four tales of violence and redemption.",
                Category = "Crime",
                CreatedByUserId = 1,
                CreatedDate = DateTime.UtcNow
            };

            var movie5 = new Movie
            {
                Id = 5,
                Name = "Forrest Gump",
                ReleaseYear = 1994,
                Synopsis = "The presidencies of Kennedy and Johnson, the events of Vietnam, Watergate, and other history unfold through the perspective of an Alabama man with an IQ of 75.",
                Category = "Drama",
                CreatedByUserId = 1,
                CreatedDate = DateTime.UtcNow
            };

            var movie6 = new Movie
            {
                Id = 6,
                Name = "The Matrix",
                ReleaseYear = 1999,
                Synopsis = "A computer hacker learns from mysterious rebels about the true nature of his reality and his role in the war against its controllers.",
                Category = "Action",
                CreatedByUserId = 1,
                CreatedDate = DateTime.UtcNow
            };

            var movie7 = new Movie
            {
                Id = 7,
                Name = "Inception",
                ReleaseYear = 2010,
                Synopsis = "A thief who steals corporate secrets through the use of dream-sharing technology is given the inverse task of planting an idea into the mind of a C.E.O.",
                Category = "Sci-Fi",
                CreatedByUserId = 1,
                CreatedDate = DateTime.UtcNow
            };

            var movie8 = new Movie
            {
                Id = 8,
                Name = "The Silence of the Lambs",
                ReleaseYear = 1991,
                Synopsis = "A young F.B.I. cadet must receive the help of an incarcerated and manipulative cannibal killer to help catch another serial killer, a madman who skins his victims.",
                Category = "Thriller",
                CreatedByUserId = 1,
                CreatedDate = DateTime.UtcNow
            };


            builder.Entity<Movie>().HasData(movie1);
            builder.Entity<Movie>().HasData(movie2);
            builder.Entity<Movie>().HasData(movie3);
            builder.Entity<Movie>().HasData(movie4);
            builder.Entity<Movie>().HasData(movie5);
            builder.Entity<Movie>().HasData(movie6);
            builder.Entity<Movie>().HasData(movie7);
            builder.Entity<Movie>().HasData(movie8);

            var rating1 = new RatingMovie
            {
                Id = 1,
                MovieId = movie1.Id,
                UsuarioId = 1,
                Rating = 4
            };

            var rating2 = new RatingMovie
            {
                Id = 2,
                MovieId = movie1.Id,
                UsuarioId =1,
                Rating = 3
            };

            var rating3 = new RatingMovie
            {
                Id = 3,
                MovieId = movie2.Id,
                UsuarioId = 2,
                Rating = 5
            };
            var rating4 = new RatingMovie
            {
                Id = 4,
                MovieId = movie2.Id,
                UsuarioId = 1,
                Rating = 4
            };

            var rating5 = new RatingMovie
            {
                Id = 5,
                MovieId = movie2.Id,
                UsuarioId = 2,
                Rating = 2
            };

            var rating6 = new RatingMovie
            {
                Id = 6,
                MovieId = movie3.Id,
                UsuarioId = 2,
                Rating = 4
            };

            var rating7 = new RatingMovie
            {
                Id = 7,
                MovieId = movie4.Id,
                UsuarioId = 1   ,
                Rating = 3
            };

            var rating8 = new RatingMovie
            {
                Id = 8,
                MovieId = movie5.Id,
                UsuarioId = 1,
                Rating = 5
            };
            builder.Entity<RatingMovie>().HasData(rating1, rating2, rating3, rating4, rating5, rating6, rating7, rating8);

        }
    }
}
