﻿using Dominio.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aplicacion.Commands.Movie
{
    public class DeleteMovie : IMessage
    {
        public int Id { get; set; }
    }
}
