using eBilet.Business.Constants;
using eBilet.Entities.Dtos.Customers;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eBilet.Business.ValidationRules.FluentValidation.Customer
{
	public class CustomerUpdateValidator : AbstractValidator<CustomerUpdateDto>
	{
		public CustomerUpdateValidator()
		{
			RuleFor(c => c.FirstName).NotEmpty().WithMessage(Messages.FirstNameNotEmpty);
			RuleFor(c => c.FirstName).NotNull();
			RuleFor(c => c.FirstName).MaximumLength(30).WithMessage(Messages.FirstNameMaxLenght);
			RuleFor(c => c.LastName).NotEmpty().WithMessage(Messages.LastNameNotEmpty);
			RuleFor(c => c.LastName).NotEmpty().WithMessage(Messages.FirstNameNotEmpty);
			RuleFor(c => c.LastName).NotNull();
			RuleFor(c => c.Age).NotEmpty().WithMessage(Messages.AgeNotEmpty);
			RuleFor(c => c.Phone).NotEmpty().WithMessage(Messages.PhoneNotEmpty);
			RuleFor(c => c.Gender).NotEmpty().WithMessage(Messages.GenderNotEmpty);
		}
	}
}
