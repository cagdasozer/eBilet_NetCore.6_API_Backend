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
	public class CustomerMap : IEntityTypeConfiguration<Customer>
	{
		public void Configure(EntityTypeBuilder<Customer> builder)
		{
			builder.HasKey(c => c.Id);
			builder.Property(c => c.Id).ValueGeneratedOnAdd();
			builder.Property(c => c.FirstName).IsRequired();
			builder.Property(c => c.FirstName).HasMaxLength(50);
			builder.Property(c => c.LastName).IsRequired();
			builder.Property(c => c.LastName).HasMaxLength(50);
			builder.Property(c => c.Age).IsRequired();
			builder.Property(c => c.Email).IsRequired();
			builder.Property(c => c.Phone).IsRequired();
			builder.Property(c => c.Gender).IsRequired();

			builder.ToTable("Customers");

		}
	}
}
