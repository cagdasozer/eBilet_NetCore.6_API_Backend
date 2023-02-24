using eBilet.Core.Entities.Abstract;
using eBilet.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eBilet.Entities.Dtos.Tickets
{
	public class TicketDto : IDto
	{
		public Ticket Ticket { get; set; }
	}
}