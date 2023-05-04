using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infraestructura.Services
{
    public class AppSettings
    {
        public string Secret { get; set; }
        public int TokenTiempoHoras { get; set; }
        public string ConnectionStringsRedis { get; set; }
    }
}
