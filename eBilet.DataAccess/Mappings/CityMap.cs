using eBilet.Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eBilet.DataAccess.Mappings
{
	public class CityMap : IEntityTypeConfiguration<City>
	{
		public void Configure(EntityTypeBuilder<City> builder)
		{
			builder.HasKey(c => c.Id);
			builder.Property(c => c.Id).ValueGeneratedOnAdd();
			builder.Property(c => c.Plaka).IsRequired();
			builder.Property(c => c.Name).IsRequired();
			builder.Property(c => c.Name).HasMaxLength(50);
			

			builder.ToTable("Cities");
		}
	}
}
