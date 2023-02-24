using eBilet.Core.Entities.Concrete;
using eBilet.DataAccess.Mapping;
using eBilet.DataAccess.Mappings;
using eBilet.Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace eBilet.DataAccess.Concrete.Context
{
	public class eBiletContext : DbContext
	{
		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		{
			optionsBuilder.UseSqlServer(@"Server=DESKTOP-RG9CD6I\SQLEXPRESS;Database=eBilet;Trusted_Connection=true");
		}

		public DbSet<Ticket> Tickets { get; set; }
		public DbSet<Route> Routes { get; set; }
		public DbSet<Customer> Customers { get; set; }
		public DbSet<Bus> Buses { get; set; }
		public DbSet<User> Users { get; set; }
		public DbSet<OperationClaim> OperationClaims { get; set; }
		public DbSet<UserOperationClaim> UserOperationClaims { get; set; }
		public DbSet<City> Cities { get; set; }

		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			modelBuilder.ApplyConfiguration(new TicketMap());
			modelBuilder.ApplyConfiguration(new RouteMap());
			modelBuilder.ApplyConfiguration(new CustomerMap());
			modelBuilder.ApplyConfiguration(new BusMap());
			modelBuilder.ApplyConfiguration(new UserMap());
			modelBuilder.ApplyConfiguration(new OperationClaimMap());
			modelBuilder.ApplyConfiguration(new UserOperationClaimMap());
			modelBuilder.ApplyConfiguration(new CityMap());
		}
	}
}
