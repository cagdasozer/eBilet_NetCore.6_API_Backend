using eBilet.Business.Abstract;
using eBilet.Business.Constants;
using eBilet.Core.Entities.Concrete;
using eBilet.Core.Utilities.Result.Abstract;
using eBilet.Core.Utilities.Result.Concrete;
using eBilet.DataAccess.Abstract;
using eBilet.DataAccess.Concrete.Repository;
using eBilet.Entities.Dtos.Tickets;
using eBilet.Entities.Dtos.Users;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eBilet.Business.Concrete
{
	public class UserManager : IUserService
	{
		IUserRepository _userRepository;

		public UserManager(IUserRepository userRepository)
		{
			_userRepository = userRepository;
		}

		public async Task AddAsync(User user)
		{
			await _userRepository.AddAsync(user);
			await _userRepository.SaveAsync();
		}

		public async Task<IResult> DeleteAsync(int userId)
		{
			var ticket = await _userRepository.GetAsync(t => t.Id == userId);
			if (ticket != null)
			{
				var deletedTicket = await _userRepository.DeleteAsync(ticket);
				await _userRepository.SaveAsync();
				return new SuccessResult(Messages.UserDeleted);
			}
			else
			{
				return new ErrorResult(Messages.UserNotFound);
			}
		}

		public async Task<IDataResult<UserListDto>> GetAllAsync()
		{
			var users = await _userRepository.GetAllAsync();
			if (users != null)
			{
				return new SuccessDataResult<UserListDto>(new UserListDto { Users = users }, Messages.UsersListed);
			}
			else
				return new ErrorDataResult<UserListDto>(Messages.UserNotFound);
		}

		public async Task<IDataResult<UserDto>> GetByIdAsync(int userId)
		{
			var user = await _userRepository.GetAsync(e => e.Id == userId);
			if (user != null)
			{
				return new SuccessDataResult<UserDto>(new UserDto { User = user }, Messages.UserFound);
			}
			else
			{
				return new ErrorDataResult<UserDto>(Messages.UserNotFound);
			}
		}

		public async Task<User> GetByMail(string email)
		{
			return await _userRepository.GetAsync(u => u.Email == email);
		}

		public async Task<List<OperationClaim>> GetClaims(User user)
		{
			return await _userRepository.GetClaims(user);
		}
	}
}
