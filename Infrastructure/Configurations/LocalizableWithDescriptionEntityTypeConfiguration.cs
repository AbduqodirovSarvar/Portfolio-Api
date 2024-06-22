using Domain.Abstractions;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Configurations
{
    public class LocalizableWithDescriptionEntityTypeConfiguration : IEntityTypeConfiguration<LocalizableWithDescriptionEntity>
    {
        public void Configure(EntityTypeBuilder<LocalizableWithDescriptionEntity> builder)
        {
            builder.HasIndex(x =>
            new {
                x.Description, x.DescriptionUz, x.DescriptionRu, x.DescriptionEn
            }).IsUnique();
        }
    }
}
