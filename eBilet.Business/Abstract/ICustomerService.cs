using eBilet.Core.Utilities.Result.Abstract;
using eBilet.Entities.Dtos.Customers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eBilet.Business.Abstract
{
	public interface ICustomerService
	{
		Task<IDataResult<CustomerListDto>> GetAllAsync();

		Task<IDataResult<CustomerDto>> GetByIdAsync(int customerId);

		Task<IResult> AddAsync(CustomerAddDto customerAddDto);

		Task<IResult> UpdateAsync(CustomerUpdateDto customerUpdateDto);

		Task<IResult> DeleteAsync(int customerId);
	}
}
