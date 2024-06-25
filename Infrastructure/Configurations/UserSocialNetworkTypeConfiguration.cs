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
    public class UserSocialNetworkTypeConfiguration : BaseEntityTypeConfiguration<UserSocialNetwork>
    {
        public override void Configure(EntityTypeBuilder<UserSocialNetwork> builder)
        {
            base.Configure(builder);
            builder.HasOne(x => x.SocialNetwork).WithMany().HasForeignKey(x => x.SocialNetworkId);
            builder.HasIndex(x => new { x.UserId, x.SocialNetworkId }).IsUnique();
            builder.HasIndex(x => x.Url).IsUnique();
        }
    }
}
