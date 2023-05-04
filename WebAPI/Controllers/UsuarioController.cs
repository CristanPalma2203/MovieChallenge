using Aplicacion.Commands.Usuario;
using Aplicacion.Dtos;
using Aplicacion.Dtos.Usuario;
using Aplicacion.Services.Comandos;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsuarioController : ControllerBase
    {
        private readonly ICommandBus commandBus;

        public string ExceptionMessage { get; private set; }

        public UsuarioController(ICommandBus commandBus)
        {
            this.commandBus = commandBus;
        }

        [HttpPost]
        public IResponse Post([FromBody] DtoUsuario usuario)
        {

            return commandBus.execute(new RegistrarUsuario { Usuario = usuario });
        }

        [HttpPost]
        [Route("login")]
        public IResponse IniciarSesion([FromBody] IniciarSesion crenciales)
        {
            var respuesta = commandBus.execute(crenciales);
            return respuesta;
        }
    }
}
