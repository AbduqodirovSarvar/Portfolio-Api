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
    public class WorkTypeEntityConfiguration : LocalizableWithDescriptionEntityTypeConfiguration<WorkType>
    {
        public override void Configure(EntityTypeBuilder<WorkType> builder)
        {
            base.Configure(builder);
        }
    }
}
