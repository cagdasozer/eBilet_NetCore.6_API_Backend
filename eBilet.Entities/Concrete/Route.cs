using eBilet.Core.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eBilet.Entities.Concrete
{
	public class Route : IEntity
	{
		public int Id { get; set; }

		public int RouteName { get; set; }

		public string Description { get; set; }
	}
}
