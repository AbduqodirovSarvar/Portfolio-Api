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
    public class SocialNetworkTypeConfiguration : LocalizableEntityTypeConfiguration<SocialNetwork>
    {
        public override void Configure(EntityTypeBuilder<SocialNetwork> builder)
        {
            base.Configure(builder);
        }
    }
}
