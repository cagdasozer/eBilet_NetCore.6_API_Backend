using eBilet.Core.Entities.Concrete;
using eBilet.Core.Utilities.Result.Abstract;
using eBilet.Core.Utilities.Security.JWT;
using eBilet.Entities.Dtos.Users;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eBilet.Business.Abstract
{
	public interface IAuthService
	{
		Task<IDataResult<User>> RegisterAsync(UserForRegisterDto userForRegisterDto, string password);

		Task<IDataResult<User>> LoginAsync(UserForLoginDto userForLoginDto);

		Task<IResult> UserExitsAsync(string email);

		Task<IDataResult<AccessToken>> CreateAccessToken(User user);
	}
}
