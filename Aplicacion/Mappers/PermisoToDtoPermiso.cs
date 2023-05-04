using Aplicacion.Dtos.Rol;
using AutoMapper;
using Dominio.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aplicacion.Mappers
{
    public class PermisoToDtoPermiso : Profile
    {
        public PermisoToDtoPermiso()
        {
            CreateMap<Permiso, DtoPermiso>().ReverseMap();
            CreateMap<IQueryable<Permiso>, IEnumerable<DtoPermiso>>().ReverseMap();
        }
    }
}
