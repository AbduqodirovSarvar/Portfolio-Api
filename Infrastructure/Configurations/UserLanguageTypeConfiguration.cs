﻿using Domain.Abstractions.Interfaces;
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
    public class UserLanguageTypeConfiguration : BaseEntityTypeConfiguration<UserLanguage>
    {
        public override void Configure(EntityTypeBuilder<UserLanguage> builder)
        {
            base.Configure(builder);
            builder.HasOne(x => x.Language).WithMany().HasForeignKey(x => x.LanguageId);
            builder.HasOne(x => x.Level).WithMany().HasForeignKey(x => x.LevelId);
            builder.HasIndex(x => new { x.UserId, x.LanguageId }).IsUnique();
        }
    }
}
