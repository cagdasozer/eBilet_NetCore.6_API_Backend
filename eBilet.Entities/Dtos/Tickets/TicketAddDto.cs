using eBilet.Core.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eBilet.Entities.Dtos.Tickets
{
	public class TicketAddDto : IDto
	{
		public string FirstName { get; set; }

		public string LastName { get; set; }

		public string Email { get; set; }

		public int SeatNo { get; set; } 

		public string FromWhere { get; set; } 

		public string ToWhere { get; set; }

		public int BusId { get; set; }

	}
}
