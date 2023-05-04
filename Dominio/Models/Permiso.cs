using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio.Models
{
    public class Permiso : IEntity
    {

        public static int idPermisoAdminitracionImportador = 21;
        public static int idPermisoProductos = 22;


        public static int idPermisoAdministracion = 1;
        public static List<int> accesosParaAdmin = new List<int> { idPermisoAdministracion, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 12, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20 };
        public int Id { get; set; }

        public string Codigo { get; set; }
        public string Nombre { get; set; }
        public int? PermisoPadre { get; set; }

    }
}
