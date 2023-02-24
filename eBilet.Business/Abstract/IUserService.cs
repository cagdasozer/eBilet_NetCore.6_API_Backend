using eBilet.Core.Entities.Concrete;
using eBilet.Core.Utilities.Result.Abstract;
using eBilet.Entities.Dtos.Tickets;
using eBilet.Entities.Dtos.Users;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eBilet.Business.Abstract
{
	public interface IUserService
	{
		Task<List<OperationClaim>> GetClaims(User user);

		Task AddAsync(User user);

		Task<User> GetByMail(string email);

		Task<IDataResult<UserListDto>> GetAllAsync();

		Task<IResult> DeleteAsync(int userId);

		Task<IDataResult<UserDto>> GetByIdAsync(int userId);

	}
}
