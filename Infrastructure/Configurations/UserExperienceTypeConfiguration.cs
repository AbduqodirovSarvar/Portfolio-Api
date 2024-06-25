using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Configurations
{
    public class UserExperienceTypeConfiguration : BaseEntityTypeConfiguration<UserExperience>
    {
        public override void Configure(EntityTypeBuilder<UserExperience> builder)
        {
            base.Configure(builder);
            builder.HasOne(x => x.WorkType).WithMany().HasForeignKey(x => x.WorkTypeId);
            builder.HasOne(x => x.Company).WithMany().HasForeignKey(x => x.CompanyId);
            builder.HasOne(x => x.Position).WithMany().HasForeignKey(x => x.PositionId);
        }
    }
}
