using AutoMapper;
using eBilet.Business.Abstract;
using eBilet.Business.Constants;
using eBilet.Core.Utilities.Result.Abstract;
using eBilet.Core.Utilities.Result.Concrete;
using eBilet.DataAccess.Abstract;
using eBilet.DataAccess.Concrete.Repository;
using eBilet.Entities.Concrete;
using eBilet.Entities.Dtos.Customers;
using eBilet.Entities.Dtos.Tickets;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eBilet.Business.Concrete
{
	public class CustomerManager :ICustomerService
	{
		ICustomerRepository _customerRepository;
		IMapper _mapper;

		public CustomerManager(ICustomerRepository customerRepository, IMapper mapper)
		{
			_customerRepository = customerRepository;
			_mapper = mapper;
		}

		public async Task<IResult> AddAsync(CustomerAddDto customerAddDto)
		{
			var customer = _mapper.Map<Customer>(customerAddDto);
			await _customerRepository.AddAsync(customer);
			await _customerRepository.SaveAsync();
			return new SuccessResult(Messages.CustomerAdded);
		}

		public async Task<IResult> DeleteAsync(int customerId)
		{
			var customer = await _customerRepository.GetAsync(t => t.Id == customerId);
			if (customer != null)
			{
				var deletedTicket = await _customerRepository.DeleteAsync(customer);
				await _customerRepository.SaveAsync();
				return new SuccessResult(Messages.CustomerDeleted);
			}
			else
			{
				return new ErrorResult(Messages.CustomerNotFound);
			}
		}

		public async Task<IDataResult<CustomerListDto>> GetAllAsync()
		{
			var customers = await _customerRepository.GetAllAsync();
			if (customers != null)
			{
				return new SuccessDataResult<CustomerListDto>(new CustomerListDto { Customers = customers }, Messages.CustomersListed);
			}
			else
				return new ErrorDataResult<CustomerListDto>(Messages.CustomerNotFound);
		}

		public async Task<IDataResult<CustomerDto>> GetByIdAsync(int customerId)
		{
			var customer = await _customerRepository.GetAsync(e => e.Id == customerId);
			if (customer != null)
			{
				return new SuccessDataResult<CustomerDto>(new CustomerDto { Customer = customer }, Messages.CustomerFound);
			}
			else
			{
				return new ErrorDataResult<CustomerDto>(Messages.CustomerNotFound);
			}
		}

		public async Task<IResult> UpdateAsync(CustomerUpdateDto customerUpdateDto)
		{
			var oldCustomer = await _customerRepository.GetAsync(t => t.Id == customerUpdateDto.Id);
			var customer = _mapper.Map<CustomerUpdateDto, Customer>(customerUpdateDto, oldCustomer);
			var updatedCustomer = await _customerRepository.UpdateAsync(customer);
			await _customerRepository.SaveAsync();
			return new SuccessResult(Messages.CustomerUpdated);
		}
	}
}
