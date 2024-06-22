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
    public class LocalizableEntityTypeConfiguration<T> : BaseEntityTypeConfiguration<T> where T : LocalizableEntity
    {
        public override void Configure(EntityTypeBuilder<T> builder)
        {
            base.Configure(builder);
            builder.HasIndex(x => new { x.Name, x.NameUz, x.NameRu, x.NameEn }).IsUnique();
        }
    }
}
