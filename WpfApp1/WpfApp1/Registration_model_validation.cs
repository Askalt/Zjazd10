﻿using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1
{
    public class Registration_model_validation : AbstractValidator<Registration_model>
    {
        public Registration_model_validation()
        {
#pragma warning disable CS0618 // Typ lub składowa jest przestarzała
            CascadeMode = CascadeMode.StopOnFirstFailure;
#pragma warning restore CS0618 // Typ lub składowa jest przestarzała

            RuleFor(x => x.login)
            .NotNull()
            .NotEmpty()
            .MinimumLength(6);

            RuleFor(x => x.password)
            .NotNull()
            .NotEmpty()
            .MinimumLength(6)
            .Must(x => x != x.ToUpper())
            .WithMessage("Password must contain lower case letters");

            RuleFor(x => x.accept)
               .Must(x => x == true)
               .WithMessage("You must accept terms!");
        }
    }
}