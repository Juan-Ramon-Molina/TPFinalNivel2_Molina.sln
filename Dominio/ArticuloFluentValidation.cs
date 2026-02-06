using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentValidation;

namespace Dominio
{
    public class ArticuloFluentValidation:AbstractValidator<Articulo>
    {
        public ArticuloFluentValidation()
        {
            //Establecer politicas del objeto.
            RuleFor(a => a.codigo)
                .NotEmpty().WithMessage("Completar")
                .MinimumLength(3).WithMessage("Minimo 3 caracteres");
            RuleFor(a => a.nombre)
                .NotEmpty().WithMessage("Completar")
                .MinimumLength(5).WithMessage("Minimo 5 caracteres");
            RuleFor(a => a.descripcion)
                .NotEmpty().WithMessage("Completar")
                .Length(5, 30).WithMessage("Entre 5 y 30 caracteres");
            RuleFor(a => a.marca)
                .NotNull().WithMessage("Seleccione");
            RuleFor(a => a.categoria)
                .NotNull().WithMessage("Seleccione");
            RuleFor(a => a.precio)
                .NotEmpty().WithMessage("Complete");

        }
    }
}
