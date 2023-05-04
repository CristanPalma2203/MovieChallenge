using Aplicacion.Commands.Usuario;
using Aplicacion.Dtos;
using Aplicacion.Dtos.Usuario;

using AutoMapper;
using Dominio.Repositories;
using System.Linq;
using Dominio.Helpers;


namespace Aplicacion.CommandHandlers.Usuario
{
    public class RegistrarUsuarioHandler : AbstractHandler<RegistrarUsuario>
    {
        private readonly IMapper mapper;
        private readonly IUsuarioRepository usuarioRepository;

        public RegistrarUsuarioHandler(IMapper mapper,  IUsuarioRepository usuarioRepository)
        {
            this.mapper = mapper;
            this.usuarioRepository = usuarioRepository;

        }
        public override IResponse Handle(RegistrarUsuario message)
        {
            var contrasena = message.Usuario.Contrasena;
            IList<int> permisosLista = new List<int>();
            if (message.Usuario.TipoUsuario.Equals("admin"))
            {
                permisosLista.Add(1);
                permisosLista.Add(2);
            }
            else {
                permisosLista.Add(3);
            }
            var usuario = mapper.Map<Dominio.Models.Usuario>(message.Usuario);
            usuario.Contrasena = contrasena;
            usuario.Inicializar(permisosLista);
            usuarioRepository.Create(usuario);

            return new OkResponse();
        }
    }
}
