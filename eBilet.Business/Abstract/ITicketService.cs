using eBilet.Core.Utilities.Result.Abstract;
using eBilet.Entities.Dtos.Tickets;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eBilet.Business.Abstract
{
	public interface ITicketService
	{
		Task<IDataResult<TicketListDto>> GetAllAsync();

		Task<IDataResult<TicketDto>> GetByIdAsync(int ticketId);

		Task<IResult> AddAsync(TicketAddDto ticketAddDto);

		Task<IResult> UpdateAsync(TicketUpdateDto ticketUpdateDto);

		Task<IResult> DeleteAsync(int ticketId);


	}
}
