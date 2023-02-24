using AutoMapper;
using eBilet.Business.Abstract;
using eBilet.Business.BusinessAspect.Autofac;
using eBilet.Business.Constants;
using eBilet.Business.ValidationRules.FluentValidation.Ticket;
using eBilet.Core.Aspects.Autofac.Validation;
using eBilet.Core.Utilities.Business;
using eBilet.Core.Utilities.Result.Abstract;
using eBilet.Core.Utilities.Result.Concrete;
using eBilet.DataAccess.Abstract;
using eBilet.Entities.Concrete;
using eBilet.Entities.Dtos.Tickets;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace eBilet.Business.Concrete
{
	public class TicketManager : ITicketService
	{
		ITicketRepository _ticketRepository;
		IMapper _mapper;

		public TicketManager(ITicketRepository ticketRepository, IMapper mapper)
		{
			_ticketRepository = ticketRepository;
			_mapper = mapper;
		}

		[SecuredOperation("admin")]
		[ValidationAspect(typeof(TicketAddValidator))]
		public async Task<IResult> AddAsync(TicketAddDto ticketAddDto)
		{
			var ticket = _mapper.Map<Ticket>(ticketAddDto);
			ticket.CreatedDate = DateTime.Now;
			await _ticketRepository.AddAsync(ticket);
			await _ticketRepository.SaveAsync();
			return new SuccessResult(Messages.TicketAdded);
		}

		[SecuredOperation("admin")]
		public async Task<IResult> DeleteAsync(int ticketId)
		{
			var ticket = await _ticketRepository.GetAsync(t => t.Id == ticketId);
			if (ticket != null)
			{
				var deletedTicket = await _ticketRepository.DeleteAsync(ticket);
				await _ticketRepository.SaveAsync();
				return new SuccessResult(Messages.TicketDeleted);
			}
			else
			{
				return new ErrorResult(Messages.TicketNotFound);
			}
		}

		public async Task<IDataResult<TicketListDto>> GetAllAsync()
		{
			var tickets = await _ticketRepository.GetAllAsync();
			if (tickets != null)
			{
				return new SuccessDataResult<TicketListDto>(new TicketListDto { Tickets = tickets }, Messages.TicketListed);
			}
			else
				return new ErrorDataResult<TicketListDto>(Messages.TicketNotFound);
		}

		public async Task<IDataResult<TicketDto>> GetByIdAsync(int ticketId)
		{
			var ticket = await _ticketRepository.GetAsync(e => e.Id == ticketId);
			if (ticket != null)
			{
				return new SuccessDataResult<TicketDto>(new TicketDto { Ticket = ticket }, Messages.TicketGeted);
			}
			else
			{
				return new ErrorDataResult<TicketDto>(Messages.TicketNotFound);
			}
		}

		[SecuredOperation("admin")]
		[ValidationAspect(typeof(TicketUpdateValidator))]
		public async Task<IResult> UpdateAsync(TicketUpdateDto ticketUpdateDto)
		{
			var oldTicket = await _ticketRepository.GetAsync(t => t.Id == ticketUpdateDto.Id);
			var ticket = _mapper.Map<TicketUpdateDto, Ticket>(ticketUpdateDto, oldTicket);
			var updatedTicket = await _ticketRepository.UpdateAsync(ticket);
			await _ticketRepository.SaveAsync();
			return new SuccessResult(Messages.TicketUpdated);
		}
	}
}
