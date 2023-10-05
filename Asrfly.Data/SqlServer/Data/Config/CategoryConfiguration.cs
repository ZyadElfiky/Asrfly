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
    public class CategoryConfiguration : IEntityTypeConfiguration<Categories>
    {
        public void Configure(EntityTypeBuilder<Categories> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Name)
                .HasColumnType("nvarchar")
                .HasMaxLength(100)
                .IsRequired();

            builder.Property(x => x.Type)
              .HasColumnType("nvarchar")
                .HasMaxLength(15)
                 .IsRequired();



            builder.Property(x => x.Details)
                .HasColumnType("nvarchar")
                .IsRequired(false);

            builder.Property(x => x.Balance)

                .HasColumnType("float");


            builder.Property(x => x.AddedDate)
                .HasColumnType("datetime2");

            builder.ToTable("Categories");
        }
    }
}
