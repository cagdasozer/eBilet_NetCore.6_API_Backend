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
	public class UserMap : IEntityTypeConfiguration<User>
	{
		public void Configure(EntityTypeBuilder<User> builder)
		{
			builder.HasKey(u => u.Id);
			builder.Property(u => u.Id).ValueGeneratedOnAdd();
			builder.Property(u => u.FirstName).IsRequired();
			builder.Property(u => u.FirstName).HasMaxLength(50);
			builder.Property(u => u.LastName).IsRequired();
			builder.Property(u => u.LastName).HasMaxLength(10);
			builder.Property(u => u.Email).IsRequired();
			builder.Property(u => u.Email).HasMaxLength(15);
			builder.Property(u => u.PasswordHash).IsRequired();
			builder.Property(u => u.PasswordHash).HasMaxLength(500);
			builder.Property(u => u.PasswordSalt).IsRequired();
			builder.Property(u => u.PasswordSalt).HasMaxLength(500);
			builder.Property(u => u.Status);

			builder.ToTable("Users");
		}
	}
}
