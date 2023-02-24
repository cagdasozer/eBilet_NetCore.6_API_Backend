using AutoMapper;
using eBilet.Business.Abstract;
using eBilet.Business.Constants;
using eBilet.Core.Utilities.Result.Abstract;
using eBilet.Core.Utilities.Result.Concrete;
using eBilet.DataAccess.Abstract;
using eBilet.DataAccess.Concrete.Repository;
using eBilet.Entities.Concrete;
using eBilet.Entities.Dtos.Buses;
using eBilet.Entities.Dtos.Tickets;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eBilet.Business.Concrete
{
	public class BusManager : IBusService
	{
		IBusRepository _busRepository;
		IMapper _mapper;

		public BusManager(IBusRepository busRepository, IMapper mapper)
		{
			_busRepository = busRepository;
			_mapper = mapper;
		}

		public async Task<IResult> AddAsync(BusAddDto busAddDto)
		{
			var bus = _mapper.Map<Bus>(busAddDto);
			await _busRepository.AddAsync(bus);
			await _busRepository.SaveAsync();
			return new SuccessResult(Messages.BusAdded);
		}

		public async Task<IResult> DeleteAsync(int busId)
		{
			var bus = await _busRepository.GetAsync(t => t.Id == busId);
			if (bus != null)
			{
				var deletedBus = await _busRepository.DeleteAsync(bus);
				await _busRepository.SaveAsync();
				return new SuccessResult(Messages.BusDeleted);
			}
			else
			{
				return new ErrorResult(Messages.BusNotFound);
			}
		}

		public async Task<IDataResult<BusListDto>> GetAllAsync()
		{
			var buses = await _busRepository.GetAllAsync();
			if (buses != null)
			{
				return new SuccessDataResult<BusListDto>(new BusListDto { Buses = buses }, Messages.BusesListed);
			}
			else
				return new ErrorDataResult<BusListDto>(Messages.BusNotFound);
		}

		public async Task<IDataResult<BusDto>> GetByIdAsync(int busId)
		{
			var bus = await _busRepository.GetAsync(e => e.Id == busId);
			if (bus != null)
			{
				return new SuccessDataResult<BusDto>(new BusDto { Bus = bus }, Messages.BusGeted);
			}
			else
			{
				return new ErrorDataResult<BusDto>(Messages.BusNotFound);
			}
		}
	}
}
