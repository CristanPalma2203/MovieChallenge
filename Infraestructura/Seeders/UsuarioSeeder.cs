using Dominio.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infraestructura.Seeders
{
    public class UsuarioSeeder
    {
        public static void Seed(ModelBuilder builder)
        {

            var usuarioAdmin = new Usuario { Id = Usuario.idUsuarioAdmin,  IdentificadorAcceso = Usuario.correoUsuarioAdmin,Email = Usuario.correoUsuarioAdmin,  Nombre = "Administrador del sistema", Contrasena = "52A5D13A7FD60FFFFF425FA65C3830A165969AA983F06C365E48BAC0F8C75CD9", };
            var usuario = new Usuario { Id = Usuario.idUsuario, IdentificadorAcceso = Usuario.correoUsuario, Email = Usuario.correoUsuario, Nombre = "User", Contrasena = "52A5D13A7FD60FFFFF425FA65C3830A165969AA983F06C365E48BAC0F8C75CD9", };
            builder.Entity<Usuario>().HasData(usuarioAdmin);
            builder.Entity<Usuario>().HasData(usuario);
        }
    }
}
