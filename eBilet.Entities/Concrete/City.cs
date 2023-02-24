﻿using eBilet.Core.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eBilet.Entities.Concrete
{
	public class City : IEntity
	{
		public int Id { get; set; }

		public int Plaka { get; set; }

		public string Name { get; set; }
	}
}
