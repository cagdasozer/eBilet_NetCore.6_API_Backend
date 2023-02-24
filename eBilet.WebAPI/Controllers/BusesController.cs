using AutoMapper;
using eBilet.Business.Abstract;
using eBilet.Entities.Concrete;
using eBilet.Entities.Dtos.Buses;
using eBilet.Entities.Dtos.Tickets;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;

namespace eBilet.WebAPI.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class BusesController : ControllerBase
	{
		private readonly IBusService _busService;
		private readonly IMapper _mapper;

		public BusesController(IBusService busService, IMapper mapper)
		{
			_busService = busService;
			_mapper = mapper;
		}

		[HttpPost("Add")]
		public async Task<IActionResult> AddAsync(BusAddDto bus)
		{
			var result = await _busService.AddAsync(bus);
			if (result.Success)
			{
				return Ok(result);
			}
			return BadRequest(result);
		}

		[HttpDelete("Delete")]
		public async Task<IActionResult> DeleteAsync(int busId)
		{
			var result = await _busService.DeleteAsync(busId);
			if (result.Success)
			{
				return Ok(result);
			}
			return BadRequest(result);
		}

		[HttpGet("GetAll")]
		public async Task<IActionResult> GetAllAsync()
		{
			var result = await _busService.GetAllAsync();
			if (result.Success)
			{
				return Ok(result);
			}
			return BadRequest(result);
		}

		[HttpGet("GetById")]
		public async Task<IActionResult> GetByIdAsync(int busId)
		{
			var result = await _busService.GetByIdAsync(busId);
			if (result.Success)
			{
				return Ok(result);
			}
			return BadRequest(result);
		}
	}
}
