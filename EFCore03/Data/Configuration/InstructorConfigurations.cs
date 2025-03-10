using EFCore03.Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCore03.Data.Configuration
{
    internal class InstructorConfigurations : IEntityTypeConfiguration<Instructor>
    {
        public void Configure(EntityTypeBuilder<Instructor> builder)
        {
            builder.Property(x => x.Salary).HasColumnType("decimal(18, 3)");
            builder.Property(x => x.HourRate).HasColumnType("decimal(18, 3)");
            builder.Property(x => x.Address).HasDefaultValue("Cairo");

            builder.HasOne(i => i.ManageDepartment)
                   .WithOne(d => d.Manager)
                   .HasForeignKey<Department>(d => d.ManagerId)
                   .OnDelete(DeleteBehavior.NoAction);
        }
    }
}
