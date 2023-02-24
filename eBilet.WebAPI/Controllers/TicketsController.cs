using AutoMapper;
using eBilet.Business.Abstract;
using eBilet.Entities.Dtos.Tickets;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace eBilet.WebAPI.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class TicketsController : ControllerBase
	{
		private readonly ITicketService _ticketService;
		private readonly IMapper _mapper;

		public TicketsController(ITicketService ticketService, IMapper mapper)
		{
			_ticketService = ticketService;
			_mapper = mapper;
		}

		[HttpPost("Add")]
		public async Task<IActionResult> AddAsync(TicketAddDto ticket)
		{
			var result = await _ticketService.AddAsync(ticket);
			if (result.Success)
			{
				return Ok(result);
			}
			return BadRequest(result);	
		}

		[HttpPut("Update")]
		public async Task<IActionResult> UpdateAsync(TicketUpdateDto ticket)
		{
			var result = await _ticketService.UpdateAsync(ticket);
			if (result.Success)
			{
				return Ok(result);
			}
			return BadRequest(result);
		}

		[HttpDelete("Delete")]
		public async Task<IActionResult> DeleteAsync(int ticketId)
		{
			var result = await _ticketService.DeleteAsync(ticketId);
			if (result.Success)
			{
				return Ok(result);
			}
			return BadRequest(result);
		}

		[HttpGet("GetAll")]
		public async Task<IActionResult> GetAllAsync()
		{
			var result = await _ticketService.GetAllAsync();
			if (result.Success)
			{
				return Ok(result);
			}
			return BadRequest(result);
		}

		[HttpGet("GetById")]
		public async Task<IActionResult> GetByIdAsync(int ticketId)
		{
			var result = await _ticketService.GetByIdAsync(ticketId);
			if (result.Success)
			{
				return Ok(result);
			}
			return BadRequest(result);
		}
	}
}
