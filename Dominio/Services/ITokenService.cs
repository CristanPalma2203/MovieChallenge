using Dominio.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio.Services
{
    public interface ITokenService
    {
        string CrearOtraerToken(Usuario usuario);
        string TraerTokenDeRequest();
        bool VerificarToken();
        string GetIdentificacionUsuario();
        string GetIdUsuarioWebService();
        int GetIdUsuario();
        

        List<Permiso> TraerPermisos();
    }
}
