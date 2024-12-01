using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommonLayer.Entities;

namespace PresentationLayer.Validations
{
    public  class MembersValidations:AbstractValidator<Members>
    {
        public MembersValidations() {

            RuleLevelCascadeMode = CascadeMode.Stop;

            RuleFor(Members => Members.RolId).NotNull().NotEmpty().WithMessage("este campo no puede se nulo");

            RuleFor(Members => Members.Names)
                .NotEmpty().WithMessage("campo para nombre obligatorio");

            RuleFor(Members=>Members.LastNames)
                .NotEmpty().WithMessage("campo para apellido obligatorio");

            RuleFor(Members=>Members.MemberUser)
                .NotEmpty().WithMessage("campo para usuario obligatorio");
            
            RuleFor(Members=> Members.Password)
                .NotEmpty().WithMessage("campo para contraseeña obligatorio");

            RuleFor(Members=>Members.Phone)
                .NotEmpty().WithMessage("campo para telefono obligatorio");

            RuleFor(Members=>Members.Email)
                .NotEmpty().WithMessage("campo para email obligatorio");

            
        }
    }
}
