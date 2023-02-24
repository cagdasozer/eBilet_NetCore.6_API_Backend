using eBilet.Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eBilet.DataAccess.Mapping
{
	public class BusMap : IEntityTypeConfiguration<Bus>
	{
		public void Configure(EntityTypeBuilder<Bus> builder)
		{
			builder.HasKey(b => b.Id);
			builder.Property(b => b.Id).ValueGeneratedOnAdd();
			builder.Property(b => b.PnrNo).IsRequired();
			builder.Property(b => b.SeatCapacity).HasMaxLength(50);

			builder.ToTable("Buses");
		}
	}
}
