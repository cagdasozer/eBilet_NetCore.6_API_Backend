using eBilet.Business.Abstract;
using eBilet.Business.Constants;
using eBilet.Business.ValidationRules.FluentValidation.User;
using eBilet.Core.Aspects.Autofac.Validation;
using eBilet.Core.Entities.Concrete;
using eBilet.Core.Utilities.Result.Abstract;
using eBilet.Core.Utilities.Result.Concrete;
using eBilet.Core.Utilities.Security.Hashing;
using eBilet.Core.Utilities.Security.JWT;
using eBilet.Entities.Dtos.Users;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eBilet.Business.Concrete
{
	public class AuthManager : IAuthService
	{
		IUserService _userService;
		ITokenHelper _tokenHelper;

		public AuthManager(IUserService userService, ITokenHelper tokenHelper)
		{
			_userService = userService;
			_tokenHelper = tokenHelper;
		}

		public async Task<IDataResult<AccessToken>> CreateAccessToken(User user)
		{
			var claims = await _userService.GetClaims(user);
			var accessToken = _tokenHelper.CreateToken(user, claims);
			return new SuccessDataResult<AccessToken>(accessToken, Messages.AccessTokenCreated);
		}

		public async Task<IDataResult<User>> LoginAsync(UserForLoginDto userForLoginDto)
		{
			var userToCheck = await _userService.GetByMail(userForLoginDto.Email);
			if (userToCheck == null)
			{
				return new ErrorDataResult<User>(Messages.UserNotFound);
			}

			if (!HashingHelper.VerifyPasswordHash(userForLoginDto.Password, userToCheck.PasswordHash, userToCheck.PasswordSalt))
			{
				return new ErrorDataResult<User>(Messages.PasswordError);
			}

			return new SuccessDataResult<User>(userToCheck, Messages.SuccessfulLogin);
		}

		[ValidationAspect(typeof(AuthRegisterValidator))]
		public async Task<IDataResult<User>> RegisterAsync(UserForRegisterDto userForRegisterDto, string password)
		{
			byte[] passwordHash, passwordSalt;
			HashingHelper.CreatePasswordHash(password, out passwordHash, out passwordSalt);
			var user = new User
			{
				FirstName = userForRegisterDto.FirstName,
				LastName = userForRegisterDto.LastName,
				Email = userForRegisterDto.Email,
				PasswordHash = passwordHash,
				PasswordSalt = passwordSalt,
				Status = true
			};
			await _userService.AddAsync(user);
			return new SuccessDataResult<User>(user, Messages.UserRegistered);
		}

		public async Task<IResult> UserExitsAsync(string email)
		{
			if (await _userService.GetByMail(email) != null)
			{
				return new ErrorResult(Messages.UserAlreadyExists);
			}
			return new SuccessResult();
		}
	}
}
