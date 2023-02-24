using eBilet.Core.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eBilet.Entities.Concrete
{
	public class Ticket : IEntity
	{
		public int Id { get; set; }

		public string FirstName { get; set; }

		public string LastName { get; set; }

		public string Email { get; set; }

		public int SeatNo { get; set; } //Koltuk No

		public string FromWhere { get; set; } //Nereden

		public string ToWhere { get; set; } //Nereye

		public DateTime CreatedDate { get; set; } //Oluşturma Tarihi

		public double Price { get; set; } //Fiyat

		public int BusId { get; set; }


	}
}
