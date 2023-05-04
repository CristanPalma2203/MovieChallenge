using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace Dominio.Models
{
    public class Movie : IEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int ReleaseYear { get; set; }
        public string Synopsis { get; set; }
        public string Category { get; set; }
        public int? CreatedByUserId { get; set; }
        public IList<RatingMovie>? MoviesRating { get; set; }
        public Usuario CreatedByUser { get; set; }
        public DateTime CreatedDate { get; set; }
    }
}
