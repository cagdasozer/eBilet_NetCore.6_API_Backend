using eBilet.Business.Abstract;
using eBilet.Core.Entities.Concrete;
using eBilet.Entities.Dtos.Users;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace eBilet.WebAPI.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class AuthController : ControllerBase
	{
		private IAuthService _authService;
		private IUserService _userService;

		public AuthController(IAuthService authService, IUserService userService)
		{
			_authService = authService;
			_userService = userService;
		}

		[HttpPost("Register")]
		public ActionResult Register(UserForRegisterDto userForRegisterDto)
		{
			var userExits = _authService.UserExitsAsync(userForRegisterDto.Email);
			if (!userExits.Result.Success)
			{
				return BadRequest(userExits.Result.Message);
			}

			var registerResult = _authService.RegisterAsync(userForRegisterDto, userForRegisterDto.Password);
			var result = _authService.CreateAccessToken(registerResult.Result.Data);
			if (result.Result.Success)
			{
				return Ok(result.Result.Data);
			}

			return BadRequest(result.Result.Message);
		}

		[HttpPost("Login")]
		public ActionResult Login(UserForLoginDto userForLoginDto)
		{
			var userToLogin = _authService.LoginAsync(userForLoginDto); 
			if (!userToLogin.Result.Success)
			{
				return BadRequest(userToLogin.Result.Message);
			}

			var result = _authService.CreateAccessToken(userToLogin.Result.Data);
			if (result.Result.Success)
			{
				return Ok(result.Result.Data);
			}

			return BadRequest(result.Result.Message);
		}
	}
}
