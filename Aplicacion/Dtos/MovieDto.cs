using Aplicacion.Dtos.Usuario;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aplicacion.Dtos
{
    public class MovieDto : IResponse
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int ReleaseYear { get; set; }
        public string Synopsis { get; set; }
        public string Category { get; set; }
        public int? CreatedByUserId { get; set; }
        public int? GlobalRate { get; set; }
        public DtoUsuario? CreatedByUser { get; set; }
        public DateTime CreatedDate { get; set; }
        public IList<RatingMovieDto>? MovieRating { get; set; }

    }
}
