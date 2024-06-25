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
    public class UserTypeConfiguration : PersonBaseEntityTypeConfiguration<User>
    {
        public override void Configure(EntityTypeBuilder<User> builder)
        {
            base.Configure(builder);
            builder.HasOne(x => x.Position).WithMany().HasForeignKey(x => x.PositionId);
            builder.HasMany(x => x.Projects).WithOne().HasForeignKey(x => x.UserId);
            builder.HasMany(x => x.Certificates).WithOne().HasForeignKey(x => x.UserId);
            builder.HasMany(x => x.Experiences).WithOne().HasForeignKey(x => x.UserId);
            builder.HasMany(x => x.Languages).WithOne().HasForeignKey(x => x.UserId);
            builder.HasMany(x => x.Skills).WithOne().HasForeignKey (x => x.UserId);
            builder.HasMany(x => x.SocialNetworks).WithOne().HasForeignKey(x => x.UserId);
            builder.HasMany(x => x.Educations).WithOne().HasForeignKey(x => x.UserId);
        }
    }
}
