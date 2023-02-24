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
	public class UserOperationClaimMap : IEntityTypeConfiguration<UserOperationClaim>
	{
		public void Configure(EntityTypeBuilder<UserOperationClaim> builder)
		{
			builder.HasKey(u => u.Id);
			builder.Property(u => u.Id).ValueGeneratedOnAdd();
			builder.Property(u => u.UserId).IsRequired();
			builder.Property(u => u.OperationClaimId).IsRequired();

			builder.ToTable("UserOperationClaims");
		}
	}
}
