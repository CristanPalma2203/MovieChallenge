using Dominio.Exceptions;
using Dominio.Models;
using Dominio.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aplicacion.Services.Validaciones
{
    public class AutenticationHelper : IAutenticationHelper
    {
        private readonly ITokenService tokeService;
        public AutenticationHelper(ITokenService tokeService)
        {
            this.tokeService = tokeService;
        }
        public void Autenticado(IList<string> permisos)
        {
            if (permisos.Count == 0) return;

            if (string.IsNullOrWhiteSpace(tokeService.TraerTokenDeRequest()))
            {
                throw new HttpException(401, "Unauthorized");
            }
            var respuesta = tokeService.VerificarToken();
            if (respuesta)
            {
                if (!BuscarEnColecciones(permisos, tokeService.TraerPermisos())) throw new HttpException(403, "Forbidden");
            }
            else
            {
                throw new HttpException(401, "Unauthorized");
            }
        }
        private bool BuscarEnColecciones(IList<string> ListaPermisos, List<Permiso> permisosToken)
        {

            var encuentra = false;
            foreach (var item in ListaPermisos)
            {
                var resultado = permisosToken.Where(c => c.Codigo == item).FirstOrDefault();
                if (resultado != null)
                {
                    encuentra = true;
                }
            }
            return encuentra;
        }

    }
    
}
