using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio.Models
{
    public class Rol : IEntity
    {
        public static int IdRolAdministracionSistema = 1;
        public static int IdRolAdministracionMovie = 2;
        public static int IdUser= 3;
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }

        public DateTime? FechaCreacion { get; set; }
        public DateTime? FechaActualizacion { get; set; }
        public IList<RolPermiso> Permisos { get; set; }

    }
}
