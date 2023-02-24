using eBilet.Core.Entities.Abstract;
using eBilet.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eBilet.Entities.Dtos.Buses
{
	public class BusListDto : IDto
	{
		public List<Bus> Buses { get; set; }
	}
}
