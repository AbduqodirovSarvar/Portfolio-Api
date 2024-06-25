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
    public class LevelTypeConfiguration : LocalizableWithDescriptionEntityTypeConfiguration<Level>
    {
        public override void Configure(EntityTypeBuilder<Level> builder)
        {
            base.Configure(builder);
        }
    }
}
