using eBilet.Core.Entities.Abstract;
using eBilet.Core.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eBilet.Entities.Dtos.Users
{
	public class UserListDto : IDto
	{
		public List<User> Users { get; set; }
	}
}
