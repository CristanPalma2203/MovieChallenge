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
    public class DtoUsuarioToUsuarioMapper : Profile
    {
        private readonly IRolRepository rolRepository;
        public DtoUsuarioToUsuarioMapper(IRolRepository rolRepository)
        {


            CreateMap<DtoUsuario, Usuario>().ForMember(c => c.Roles, f => f.Ignore());
            this.rolRepository = rolRepository;
        }

        public IList<DtoRol> getRoles(IList<UsuarioRol> usuarioRol)
        {
            var respuesta = new List<DtoRol>();
            foreach (var item in usuarioRol)
            {
                var rol = rolRepository.GetByIdConPermisos(item.RolId);
                respuesta.Add(new DtoRol { Id = item.RolId, Descripcion = rol.Nombre });
            }
            return respuesta;
        }
    }
}
