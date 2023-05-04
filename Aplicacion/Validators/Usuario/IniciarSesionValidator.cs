using Aplicacion.Commands.Usuario;
using Aplicacion.Services.Validaciones;
using Dominio.Repositories;
using FluentValidation;
using Dominio.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio.Especifications;

namespace Aplicacion.Validators.Usuario
{
    public class IniciarSesionValidator : Validador<IniciarSesion>
    {
        private readonly IUsuarioRepository usuarioRepository;

        public IniciarSesionValidator(IUsuarioRepository usuarioRepository, IAutenticationHelper autenticationHelper) : base(autenticationHelper)
        {
            RuleFor(x => x.Usuario).NotEmpty().WithMessage("Ingrese el identificador");


            RuleFor(x => x.Contrasena).NotEmpty().WithMessage("Ingrese la Contraseña");

            RuleFor(x => x).NotEmpty()
                .Must(c => ValidarCredencialesUsuario(c.Usuario, c.Contrasena))
                .WithMessage("Usuario o contraseña es incorrecto");

            this.usuarioRepository = usuarioRepository;

        }
        private bool ValidarCredencialesUsuario(string usuario, string contrasena)
        {
            var resultado = usuarioRepository.Filter(new BuscarUsuarioPorIdentificadorYContrasena(usuario, contrasena));
            return resultado.Count() > 0;
        }

        public override IList<string> Permisos => new List<string>();
    }
}
