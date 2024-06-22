using Domain.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Configurations
{
    public class UIThemeTypeConfiguration : LocalizableEntityTypeConfiguration<UITheme>
    {
        public override void Configure(EntityTypeBuilder<UITheme> builder)
        {
            base.Configure(builder);
        }
    }
}
