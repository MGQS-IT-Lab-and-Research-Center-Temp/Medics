using Medics.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Medics.Context.EntityConfiguration
{
    public class RoleEntityTypeConfiguration : IEntityTypeConfiguration<Role>
    {
      public void Configure(EntityTypeBuilder<Role> builder)
        {
            builder.ToTable("Roles");

            builder.HasKey(r => r.Id);

            builder.Property(r => r.RoleName)
                   .HasMaxLength(50)
                   .IsRequired();

            builder.HasIndex(r => r.RoleName)
                     .IsUnique();

            builder.Property(r => r.Description)
                   .HasMaxLength(200);

            builder.HasMany(r => r.Users)
                   .WithOne(r => r.Role)
                   .HasForeignKey(u => u.RoleId);
        }
    }
}