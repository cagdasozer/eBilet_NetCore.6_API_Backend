using eBilet.Core.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eBilet.Entities.Dtos.Buses
{
	public class BusAddDto : IDto
	{
		public int PnrNo { get; set; }

		public int SeatCapacity { get; set; }
	}
}
