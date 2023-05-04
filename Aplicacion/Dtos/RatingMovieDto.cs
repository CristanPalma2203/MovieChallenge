
using Aplicacion.Dtos.Usuario;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aplicacion.Dtos
{
    public class RatingMovieDto
    {
        public int Id { get; set; }
        public MovieDto? Movie { get; set; }
        public int MovieId { get; set; }
        public DtoUsuario? Usuario { get; set; }
        public int UsuarioId { get; set; }
        public int Rating { get; set; }

    }
}
