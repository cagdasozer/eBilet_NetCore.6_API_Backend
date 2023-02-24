using AutoMapper;
using eBilet.Business.Abstract;
using eBilet.Entities.Concrete;
using eBilet.Entities.Dtos.Customers;
using eBilet.Entities.Dtos.Tickets;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace eBilet.WebAPI.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class CustomersController : ControllerBase
	{
		private readonly ICustomerService _customerService;
		private readonly IMapper _mapper;

		public CustomersController(ICustomerService customerService, IMapper mapper)
		{
			_customerService = customerService;
			_mapper = mapper;
		}

		[HttpPost("Add")]
		public async Task<IActionResult> AddAsync(CustomerAddDto customer)
		{
			var result = await _customerService.AddAsync(customer);
			if (result.Success)
			{
				return Ok(result);
			}
			return BadRequest(result);
		}

		[HttpPut("Update")]
		public async Task<IActionResult> UpdateAsync(CustomerUpdateDto customer)
		{
			var result = await _customerService.UpdateAsync(customer);
			if (result.Success)
			{
				return Ok(result);
			}
			return BadRequest(result);
		}

		[HttpDelete("Delete")]
		public async Task<IActionResult> DeleteAsync(int customerId)
		{
			var result = await _customerService.DeleteAsync(customerId);
			if (result.Success)
			{
				return Ok(result);
			}
			return BadRequest(result);
		}

		[HttpGet("GetAll")]
		public async Task<IActionResult> GetAllAsync()
		{
			var result = await _customerService.GetAllAsync();
			if (result.Success)
			{
				return Ok(result);
			}
			return BadRequest(result);
		}

		[HttpGet("GetById")]
		public async Task<IActionResult> GetByIdAsync(int customerId)
		{
			var result = await _customerService.GetByIdAsync(customerId);
			{
				return Ok(result);
			}
			return BadRequest(result);
		}
	}
}

