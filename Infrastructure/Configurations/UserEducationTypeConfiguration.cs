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
    public class UserEducationTypeConfiguration : BaseEntityTypeConfiguration<UserEducation>
    {
        public override void Configure(EntityTypeBuilder<UserEducation> builder)
        {
            base.Configure(builder);
            builder.HasOne(x => x.Education).WithMany().HasForeignKey(x => x.EducationId);
        }
    }
}
