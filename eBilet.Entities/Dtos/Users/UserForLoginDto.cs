using eBilet.Core.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eBilet.Entities.Dtos.Users
{
	public class UserForLoginDto : IDto
	{
		public string Email { get; set; }

		public string Password { get; set; }
	}
}
