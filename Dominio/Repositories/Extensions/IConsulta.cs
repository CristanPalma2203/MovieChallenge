using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio.Repositories.Extensions
{
    public interface IConsulta
    {
        int PageNumber { get; set; }
        int PageSize { get; set; }
        string? NameOrSypnosis { get; set; }
        string? Category { get; set; }
        string? OrderBy { get; set; }
        int? Year { get; set; }
    }
}
