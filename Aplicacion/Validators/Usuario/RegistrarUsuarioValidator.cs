using Aplicacion.Commands.Usuario;
using Aplicacion.Services.Validaciones;
using Dominio.Especifications;
using Dominio.Repositories;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;


namespace Aplicacion.Validators.Usuario
{
    public class RegistrarUsuarioValidator : Validador<RegistrarUsuario>
    {
        public RegistrarUsuarioValidator(IUsuarioRepository usuarioRepository, IAutenticationHelper autenticationHelper) : base(autenticationHelper)
        {
            RuleFor(x => x.Usuario.Nombre).NotEmpty();
            RuleFor(x => x.Usuario.Email).NotEmpty().Must(c => usuarioRepository.Filter(new BuscarUsuarioInternoPorEmail(c)).Count() == 0)
                .WithMessage("Ya existe un usuario con el mismo Correo");
            RuleFor(x => x.Usuario.IdentificadorAcceso).NotEmpty().Must(c => usuarioRepository.Filter(new BuscarUsuarioInternoPorEmail(c)).Count() == 0)
                .WithMessage("Ya existe un usuario con el mismo usuario");

        }

        public override IList<string> Permisos => new List<string> { "usuario-crear", "administracion" };
    }
}
