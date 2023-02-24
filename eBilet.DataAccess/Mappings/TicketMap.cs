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
	public class TicketMap : IEntityTypeConfiguration<Ticket>
	{
		public void Configure(EntityTypeBuilder<Ticket> builder)
		{
			builder.HasKey(t => t.Id);
			builder.Property(t => t.Id).ValueGeneratedOnAdd();
			builder.Property(t => t.FirstName).IsRequired();
			builder.Property(t => t.FirstName).HasMaxLength(50);
			builder.Property(t => t.LastName).IsRequired();
			builder.Property(t => t.LastName).HasMaxLength(50);
			builder.Property(t => t.Email).IsRequired();
			builder.Property(t => t.SeatNo).IsRequired();
			builder.Property(t => t.FromWhere).IsRequired();
			builder.Property(t => t.ToWhere).IsRequired();
			builder.Property(t => t.Price).IsRequired();
			builder.Property(t => t.CreatedDate).IsRequired();

			builder.ToTable("Tickets");
		}
	}
}
