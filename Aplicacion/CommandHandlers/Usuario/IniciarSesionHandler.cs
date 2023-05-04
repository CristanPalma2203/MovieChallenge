using Aplicacion.Commands.Usuario;
using Aplicacion.Dtos.Usuario;
using Aplicacion.Dtos;
using AutoMapper;
using Dominio.Especifications;
using Dominio.Repositories;
using Dominio.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aplicacion.CommandHandlers.Usuario
{
    public class IniciarSesionHandler : AbstractHandler<IniciarSesion>
    {
        private readonly IUsuarioRepository usuarioRepository;
        private readonly IMapper mapper;
        private readonly ITokenService tokenService;


        public IniciarSesionHandler(IUsuarioRepository usuarioRepository, IMapper mapper,
            ITokenService tokenService)
        {
            this.usuarioRepository = usuarioRepository;
            this.mapper = mapper;
            this.tokenService = tokenService;
        }


        public override IResponse Handle(IniciarSesion message)
        {
            DtoUsuarioLogin respuesta;
            Dominio.Models.Usuario usuario;
            usuario = usuarioRepository.GetUsuarioConRolPermiso(new BuscarUsuarioPorIdentificadorYContrasena(message.Usuario, message.Contrasena));

            respuesta = mapper.Map<DtoUsuarioLogin>(usuario);
            respuesta.Token = tokenService.CrearOtraerToken(usuario);
            return respuesta;

        }

    }
}
