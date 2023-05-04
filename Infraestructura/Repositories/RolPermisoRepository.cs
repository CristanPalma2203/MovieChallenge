﻿using Dominio.Models;
using Dominio.Repositories;
using Infraestructura.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infraestructura.Repositories
{
    public class RolPermisoRepository : GenericRepository<RolPermiso>, IRolPermisoRepository
    {
        public RolPermisoRepository(MovieContext dbContext) : base(dbContext)
        {
        }
    }
}
