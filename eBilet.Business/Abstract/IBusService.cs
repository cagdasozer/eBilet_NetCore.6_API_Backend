using eBilet.Core.Utilities.Result.Abstract;
using eBilet.Entities.Dtos.Buses;
using eBilet.Entities.Dtos.Tickets;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eBilet.Business.Abstract
{
	public interface IBusService 
	{
		Task<IDataResult<BusListDto>> GetAllAsync();

		Task<IDataResult<BusDto>> GetByIdAsync(int busId);

		Task<IResult> AddAsync(BusAddDto busAddDto);

		Task<IResult> DeleteAsync(int busId);
	}
}
