using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio.Models
{
    public class RatingMovie : IEntity
    {
        public int Id { get; set; }
        public Movie Movie { get; set; }
        public int MovieId { get; set; }
        public Usuario Usuario { get; set; }    
        public int UsuarioId { get; set; }
        public int Rating { get; set; }

    }
}
