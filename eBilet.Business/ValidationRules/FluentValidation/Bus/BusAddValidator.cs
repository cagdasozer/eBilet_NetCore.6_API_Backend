using eBilet.Business.Constants;
using eBilet.Entities.Dtos.Buses;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eBilet.Business.ValidationRules.FluentValidation.Bus
{
	public class BusAddValidator :AbstractValidator<BusAddDto>
	{
		public BusAddValidator()
		{
			RuleFor(b => b.PnrNo).NotEmpty().WithMessage(Messages.PnrNoNotEmpty);
			RuleFor(b => b.SeatCapacity).NotEmpty().WithMessage(Messages.SeatCapacityNotEmpty);
		}	
	}
}
