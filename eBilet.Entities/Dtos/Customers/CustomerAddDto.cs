using eBilet.Core.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eBilet.Entities.Dtos.Customers
{
	public class CustomerAddDto : IDto
	{
		public string FirstName { get; set; }

		public string LastName { get; set; }

		public string Age { get; set; }

		public string Email { get; set; }

		public string Phone { get; set; }

		public string Gender { get; set; }
	}
}
