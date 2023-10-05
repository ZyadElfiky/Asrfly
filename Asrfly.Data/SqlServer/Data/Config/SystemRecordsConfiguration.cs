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
    public class SystemRecordsConfiguration : IEntityTypeConfiguration<SystemRecords>
    {
        public void Configure(EntityTypeBuilder<SystemRecords> builder)
        {
            builder.HasKey(x => x.Id);

            builder.Property(x => x.UserName)
                .HasColumnType("nvarchar")
                .HasMaxLength(100)
                .IsRequired(false);

            builder.Property(x => x.Title)
              .HasColumnType("nvarchar")
                .HasMaxLength(15)
                 .IsRequired(false);



            builder.Property(x => x.Details)
                .HasColumnType("nvarchar")
                .IsRequired(false);


            builder.Property(x => x.AddedDate)
                .HasColumnType("datetime2");

            builder.ToTable("SystemRecords");
        }
    }
}
