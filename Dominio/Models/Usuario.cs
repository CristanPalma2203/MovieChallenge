using Dominio.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio.Models
{
    public class Usuario : IEntity
    {
        public static int idUsuarioAdmin = 1;
        public static int idUsuario = 2;
        public static string correoUsuarioAdmin = "admin@gmail.com";
        public static string correoUsuario = "user@gmail.com";
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Email { get; set; }
        public string IdentificadorAcceso { get; set; }
        public string Contrasena { get; set; }
        public IList<UsuarioRol> Roles { get; set; }
        public void Inicializar(IList<int> roles)
        {
            Contrasena = getPassword(Contrasena);
            CrearUsuarioRol(roles);
        }
        public void CrearUsuarioRol(IList<int> permisosLista)
        {
            this.Roles = new List<UsuarioRol>();
            foreach (var item in permisosLista)
            {
                Roles.Add(new UsuarioRol { RolId = item, Usuario = this });
            }

        }
        public static string getPassword(string constrasena)
        {
            return PasswordHelper.getPassword(constrasena);
        }
    }
}
