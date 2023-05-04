using Dominio.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Infraestructura.Seeders
{
    public static class RolPermisoSeeder
    {
        private static int Id = 0;
        private static int Id2 = 0;
        public static void Seed(ModelBuilder builder)
        {
            var permisoModuloAutenticacion = new Permiso { Id = getId(), Codigo = "administracion", Nombre = "ADMINISTRACIÓN" };
            var usuarios = new Permiso { PermisoPadre = permisoModuloAutenticacion.Id, Id = getId(), Codigo = "usuarios", Nombre = "Usuario" };
            var permisoUsuario = new Permiso { PermisoPadre = usuarios.Id, Id = getId(), Codigo = "usuario-listar", Nombre = "Lista Usuarios" };
            var permisoUsuarioCrear = new Permiso { PermisoPadre = usuarios.Id, Id = getId(), Codigo = "usuario-crear", Nombre = "Crear usuario" };
            var usuarioeditar = new Permiso { PermisoPadre = usuarios.Id, Id = getId(), Codigo = "usuario-editar", Nombre = "Editar usuario" };
            var usuarioVer = new Permiso { PermisoPadre = usuarios.Id, Id = getId(), Codigo = "usuario-ver", Nombre = "Ver usuario" };

            var rolAdminitracionSistema = new Rol { Id = Rol.IdRolAdministracionSistema, Descripcion = "Rol para la administracion", FechaCreacion = DateTime.Now, Nombre = "Administración del Sistema" };




            var rolPermisoAdmin = new RolPermiso { Id = getId2(), PermisoId = permisoModuloAutenticacion.Id, RolId = rolAdminitracionSistema.Id };
            var rolPermisoAdmin2 = new RolPermiso { Id = getId2(), PermisoId = permisoUsuario.Id, RolId = rolAdminitracionSistema.Id };
            var rolPermisoAdmin3 = new RolPermiso { Id = getId2(), PermisoId = permisoUsuarioCrear.Id, RolId = rolAdminitracionSistema.Id };
            var rolPermisoAdmin4 = new RolPermiso { Id = getId2(), PermisoId = usuarioeditar.Id, RolId = rolAdminitracionSistema.Id };
            var rolPermisoAdmin5 = new RolPermiso { Id = getId2(), PermisoId = usuarioVer.Id, RolId = rolAdminitracionSistema.Id };
            var rolPermisoAdmin6 = new RolPermiso { Id = getId2(), PermisoId = usuarios.Id, RolId = rolAdminitracionSistema.Id };



            //admin
            builder.Entity<Rol>().HasData(rolAdminitracionSistema);
            builder.Entity<RolPermiso>().HasData(rolPermisoAdmin);
            builder.Entity<RolPermiso>().HasData(rolPermisoAdmin2);
            builder.Entity<RolPermiso>().HasData(rolPermisoAdmin3);
            builder.Entity<RolPermiso>().HasData(rolPermisoAdmin4);
            builder.Entity<RolPermiso>().HasData(rolPermisoAdmin5);
            builder.Entity<RolPermiso>().HasData(rolPermisoAdmin6);

            builder.Entity<Permiso>().HasData(permisoModuloAutenticacion);
            builder.Entity<Permiso>().HasData(usuarios);
            builder.Entity<Permiso>().HasData(permisoUsuario);
            builder.Entity<Permiso>().HasData(permisoUsuarioCrear);
            builder.Entity<Permiso>().HasData(usuarioeditar);
            builder.Entity<Permiso>().HasData(usuarioVer);

            //movie
            var permisoModuloMovie = new Permiso { Id = getId(), Codigo = "modulo-movie", Nombre = "Peliculas" };

            var movies = new Permiso { PermisoPadre = permisoModuloMovie.Id, Id = getId(), Codigo = "movie", Nombre = "Movie" };
            var permisoMovie = new Permiso { PermisoPadre = movies.Id, Id = getId(), Codigo = "movie-listar", Nombre = "Lista Movie" };
            var permisoMovieCrear = new Permiso { PermisoPadre = movies.Id, Id = getId(), Codigo = "movie-crear", Nombre = "Crear Movie" };
            var movieeditar = new Permiso { PermisoPadre = movies.Id, Id = getId(), Codigo = "movie-editar", Nombre = "Editar Movie" };
            var movieEliminar = new Permiso { PermisoPadre = movies.Id, Id = getId(), Codigo = "movie-eliminar", Nombre = "Eliminar Movie" };

            var rolAdminitracionMovie = new Rol { Id = Rol.IdRolAdministracionMovie, Descripcion = "Rol para la administracion de peliculas", FechaCreacion = DateTime.Now, Nombre = "Administración de peliculas" };

            var rolPermisoMovie = new RolPermiso { Id = getId2(), PermisoId = permisoModuloMovie.Id, RolId = rolAdminitracionMovie.Id };
            var rolPermisoMovie2 = new RolPermiso { Id = getId2(), PermisoId = permisoMovie.Id, RolId = rolAdminitracionMovie.Id };
            var rolPermisoMovie3 = new RolPermiso { Id = getId2(), PermisoId = permisoMovieCrear.Id, RolId = rolAdminitracionMovie.Id };
            var rolPermisoMovie4 = new RolPermiso { Id = getId2(), PermisoId = movieeditar.Id, RolId = rolAdminitracionMovie.Id };
            var rolPermisoMovie5 = new RolPermiso { Id = getId2(), PermisoId = movieEliminar.Id, RolId = rolAdminitracionMovie.Id };
            var rolPermisoMovie6 = new RolPermiso { Id = getId2(), PermisoId = movies.Id, RolId = rolAdminitracionMovie.Id };

            builder.Entity<Rol>().HasData(rolAdminitracionMovie);
            builder.Entity<RolPermiso>().HasData(rolPermisoMovie);
            builder.Entity<RolPermiso>().HasData(rolPermisoMovie2);
            builder.Entity<RolPermiso>().HasData(rolPermisoMovie3);
            builder.Entity<RolPermiso>().HasData(rolPermisoMovie4);
            builder.Entity<RolPermiso>().HasData(rolPermisoMovie5);
            builder.Entity<RolPermiso>().HasData(rolPermisoMovie6);

            builder.Entity<Permiso>().HasData(permisoModuloMovie);
            builder.Entity<Permiso>().HasData(movies);
            builder.Entity<Permiso>().HasData(permisoMovie);
            builder.Entity<Permiso>().HasData(permisoMovieCrear);
            builder.Entity<Permiso>().HasData(movieeditar);
            builder.Entity<Permiso>().HasData(movieEliminar);

            //rol para usuarios externos

            var rolUser = new Rol { Id = Rol.IdUser, Descripcion = "Rol para usuarios externos", FechaCreacion = DateTime.Now, Nombre = "Rol para usuarios externos" };

            var rolPermisoMovieUser = new RolPermiso { Id = getId2(), PermisoId = movies.Id, RolId = rolAdminitracionMovie.Id };
            var rolPermisoMovie2User = new RolPermiso { Id = getId2(), PermisoId = permisoMovie.Id, RolId = rolAdminitracionMovie.Id };
            builder.Entity<Rol>().HasData(rolUser);
            builder.Entity<RolPermiso>().HasData(rolPermisoMovieUser);
            builder.Entity<RolPermiso>().HasData(rolPermisoMovie2User);


            var rolParaAdmin= new UsuarioRol { Id = getId2(), RolId = rolAdminitracionMovie.Id , UsuarioId= Usuario.idUsuarioAdmin};
            var rolParaAdmin2 = new UsuarioRol { Id = getId2(), RolId = rolAdminitracionSistema.Id, UsuarioId = Usuario.idUsuarioAdmin };
            var rolParaUser = new UsuarioRol { Id = getId2(),RolId = rolUser.Id, UsuarioId = Usuario.idUsuario };


            builder.Entity<UsuarioRol>().HasData(rolParaAdmin);
            builder.Entity<UsuarioRol>().HasData(rolParaAdmin2);
            builder.Entity<UsuarioRol>().HasData(rolParaUser);
        }

        private static int getId()
        {
            Id = Id + 1;
            return Id;
        }
        private static int getId2()
        {
            Id2 = Id2 + 1;
            return Id2;
        }

    }
}
