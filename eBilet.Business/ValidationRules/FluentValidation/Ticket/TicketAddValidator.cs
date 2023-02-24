using eBilet.Business.Constants;
using eBilet.Entities.Dtos.Tickets;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eBilet.Business.ValidationRules.FluentValidation.Ticket
{
    public class TicketAddValidator : AbstractValidator<TicketAddDto>
    {
        public TicketAddValidator()
        {
            RuleFor(t => t.FirstName).NotEmpty().WithMessage(Messages.FirstNameNotEmpty);
            RuleFor(t => t.FirstName).NotNull();
            RuleFor(t => t.FirstName).MaximumLength(30).WithMessage(Messages.FirstNameMaxLenght);
            RuleFor(t => t.LastName).NotEmpty().WithMessage(Messages.LastNameNotEmpty);
            RuleFor(t => t.LastName).NotNull();
            RuleFor(t => t.LastName).MaximumLength(30).WithMessage(Messages.LastNameMaxLenght);
            RuleFor(t => t.Email).NotEmpty().WithMessage(Messages.EmailNotEmpty);
            RuleFor(t => t.SeatNo).NotEmpty().WithMessage(Messages.SeatNoNotEmpty);
            RuleFor(t => t.FromWhere).NotEmpty().WithMessage(Messages.FromWhereNotEmpty);
            RuleFor(t => t.ToWhere).NotEmpty().WithMessage(Messages.ToWhereNotEmpty);
            RuleFor(t => t.BusId).NotEmpty().WithMessage(Messages.BusIdNotEmpty);
        }
    }
}
