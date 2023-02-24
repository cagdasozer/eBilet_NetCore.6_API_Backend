using eBilet.Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eBilet.DataAccess.Mapping
{
	public class RouteMap : IEntityTypeConfiguration<Route>
	{
		public void Configure(EntityTypeBuilder<Route> builder)
		{
			builder.HasKey(r => r.Id);
			builder.Property(r => r.Id).ValueGeneratedOnAdd();
			builder.Property(r => r.RouteName).IsRequired();
			builder.Property(r => r.Description);

			builder.ToTable("Routes");
		}
	}
}
