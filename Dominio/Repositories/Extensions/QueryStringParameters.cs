﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio.Repositories.Extensions
{
    public abstract class QueryStringParameters : IConsulta
    {
        const int maxPageSize = 50;
        public int PageNumber { get; set; } = 1;
        public string? NameOrSypnosis { get; set; }
        public string? Category { get; set; }
        public int? Year { get; set; }
        public string? OrderBy { get; set; }

        private int _pageSize = 10;
        public int PageSize
        {
            get
            {
                return _pageSize;
            }
            set
            {
                _pageSize = value > maxPageSize ? maxPageSize : value;
            }
        }
    }
}
