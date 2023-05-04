using Aplicacion.Dtos.Rol;
using Aplicacion.Dtos.Usuario;
using AutoMapper;
using Dominio.Models;
using Dominio.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aplicacion.Mappers
{
    public class UsuarioToDtoLogin : Profile
    {
        private readonly IPermisoRepository permisoRepository;

        public UsuarioToDtoLogin(IPermisoRepository permisoRepository)
        {
            CreateMap<Usuario, DtoUsuarioLogin>()
                .ForMember(c => c.Roles, f => f.MapFrom((usuario, orderDto, i, context) => GetRoles(usuario.Roles, usuario, context)));
            this.permisoRepository = permisoRepository;
        }

        public IList<DtoRol> GetRoles(IList<UsuarioRol> usuarioRol, Usuario usuario, ResolutionContext context)
        {
            var respuesta = new List<DtoRol>();

            foreach (var rol in usuarioRol)
            {
                respuesta.Add(new DtoRol {Nombre= rol.Rol.Nombre, Id = rol.RolId, Descripcion = rol.Rol.Descripcion, PermisosConMetadata = GetPermisos(rol.Rol.Permisos, context) });
            }
            return respuesta;
        }
        private List<DtoPermiso> GetPermisos(IList<RolPermiso> permisos, ResolutionContext context)
        {
            var respuesta = new List<DtoPermiso>();
            foreach (var permiso in permisos)
            {
                respuesta.Add(context.Mapper.Map<DtoPermiso>(permiso.Permiso));
            };
            return respuesta;
        }

        private List<DtoPermiso> GetAllPermisos(ResolutionContext context)
        {
            var respuesta = new List<DtoPermiso>();
            var lista = permisoRepository.GetAll();
            lista = lista.Where(c => Permiso.accesosParaAdmin.Contains(c.Id));
            foreach (var permiso in lista) respuesta.Add(context.Mapper.Map<DtoPermiso>(permiso));
            return respuesta;
        }
    }
}
