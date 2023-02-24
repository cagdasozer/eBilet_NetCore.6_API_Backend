using eBilet.Business.Constants;
using eBilet.Entities.Dtos.Users;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eBilet.Business.ValidationRules.FluentValidation.User
{
	public class AuthRegisterValidator : AbstractValidator<UserForRegisterDto>
	{
		public AuthRegisterValidator()
		{
			RuleFor(u => u.FirstName).NotEmpty().WithMessage(Messages.FirstNameNotEmpty);
			RuleFor(u => u.FirstName).NotNull();
			RuleFor(u => u.FirstName).MaximumLength(50).WithMessage(Messages.FirstNameTooLong);
			RuleFor(u => u.LastName).NotEmpty().WithMessage(Messages.LastNameNotEmpty);
			RuleFor(u => u.LastName).NotNull();
			RuleFor(u => u.LastName).MaximumLength(50).WithMessage(Messages.LastNameTooLong);
			RuleFor(u => u.Email).NotEmpty().WithMessage(Messages.MailNotEmpty);
			RuleFor(u => u.Email).NotNull();
			RuleFor(u => u.Email).MaximumLength(50).WithMessage(Messages.EmailTooLong);
			
		}
	}
}
