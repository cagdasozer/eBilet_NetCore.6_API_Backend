using eBilet.Core.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eBilet.Entities.Dtos.Tickets
{
	public class TicketUpdateDto : IDto
	{
		public int Id { get; set; }

		public string FirstName { get; set; }

		public string LastName { get; set; }

		public string Email { get; set; }

		public int SeatNo { get; set; } 

		public string FromWhere { get; set; } 

		public string ToWhere { get; set; } 

		public double Price { get; set; } 
	}
}
