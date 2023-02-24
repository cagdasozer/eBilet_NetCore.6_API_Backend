using eBilet.Core.Entities.Concrete;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eBilet.DataAccess.Mappings
{
	public class OperationClaimMap : IEntityTypeConfiguration<OperationClaim>
	{
		public void Configure(EntityTypeBuilder<OperationClaim> builder)
		{
			builder.HasKey(o => o.Id);
			builder.Property(o => o.Id).ValueGeneratedOnAdd();
			builder.Property(o => o.Name).IsRequired();
			builder.Property(o => o.Name).HasMaxLength(50);

			builder.ToTable("OperationClaims");
		}
	}
}
