﻿using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Configurations
{
    public class UserSkillTypeConfiguration : BaseEntityTypeConfiguration<UserSkill>
    {
        public override void Configure(EntityTypeBuilder<UserSkill> builder)
        {
            base.Configure(builder);
            builder.HasOne(x => x.Skill).WithMany().HasForeignKey(x => x.SkillId);
            builder.HasIndex(x => new {x.UserId, x.SkillId}).IsUnique();
        }
    }
}
