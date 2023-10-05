using Asrfly.Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Asrfly.Data.SqlServer.Data.Config
{
    public class CustomerConfiguration : IEntityTypeConfiguration<Customers>
    {
        public void Configure(EntityTypeBuilder<Customers> builder)
        {
            builder.HasKey(x => x.Id);
          
            builder.Property(x => x.Name)
                .HasColumnType("nvarchar")
                .HasMaxLength(100)
                .IsRequired();

            builder.Property(x => x.Email)
               .HasColumnType("nvarchar")
               .HasMaxLength(100)
               .IsRequired();

            builder.Property(x => x.PhoneNumber)
               .HasColumnType("nvarchar")
               .HasMaxLength(20)
               .IsRequired(false);

            builder.Property(x => x.Address)
               .HasColumnType("nvarchar")
               .HasMaxLength(100)
               .IsRequired(false);


            builder.Property(x => x.Details)
                .HasColumnType("nvarchar")
                .IsRequired(false);

            builder.Property(x => x.Balance)
                .HasColumnType("float");


            builder.Property(x => x.AddedDate)
                .HasColumnType("datetime2");

            builder.ToTable("Customers");
        }
    }
}
