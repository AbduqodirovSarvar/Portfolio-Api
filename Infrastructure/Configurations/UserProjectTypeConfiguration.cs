﻿using Domain.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Configurations
{
    public class UserProjectTypeConfiguration : LocalizableWithDescriptionEntityTypeConfiguration<UserProject>
    {
        public override void Configure(EntityTypeBuilder<UserProject> builder)
        {
            base.Configure(builder);
        }
    }
}
