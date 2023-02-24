using AutoMapper;
using eBilet.Entities.Concrete;
using eBilet.Entities.Dtos.Buses;
using eBilet.Entities.Dtos.Customers;
using eBilet.Entities.Dtos.Tickets;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eBilet.DataAccess.AutoMapper
{
	public class MapperProfile : Profile
	{
		public MapperProfile()
		{
			CreateMap<TicketAddDto, Ticket>();
			CreateMap<TicketUpdateDto, Ticket>();
			CreateMap<Ticket, TicketUpdateDto>();

			CreateMap<CustomerAddDto, Customer>();
			CreateMap<Customer, CustomerUpdateDto>();
			CreateMap<CustomerUpdateDto, Customer>();

			CreateMap<BusAddDto, Bus>();

		}
	}
}
