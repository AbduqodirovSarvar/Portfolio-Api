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
    public class UserLanguageTypeConfiguration : IEntityTypeConfiguration<UserLanguage>
    {
        public void Configure(EntityTypeBuilder<UserLanguage> builder)
        {
            builder.HasOne(x => x.User).WithMany(x => x.Languages).HasForeignKey(x => x.UserId);
            builder.HasOne(x => x.Language).WithMany().HasForeignKey(x => x.LanguageId);
            builder.HasOne(x => x.Level).WithMany().HasForeignKey(x => x.LevelId);
            builder.HasIndex(x => new { x.UserId, x.LanguageId }).IsUnique();
        }

        public static readonly List<UserLanguage> DefaultUserLanguages = [
            new UserLanguage(){
                UserId = UserTypeConfiguration.DefaultUser.Id,
                LanguageId = LanguageTypeConfguration.DefaultLanguages[0].Id,
                LevelId = LevelTypeConfiguration.DefaultLevels.Last().Id,
            },
            new UserLanguage(){
                UserId = UserTypeConfiguration.DefaultUser.Id,
                LanguageId = LanguageTypeConfguration.DefaultLanguages[1].Id,
                LevelId = LevelTypeConfiguration.DefaultLevels[3].Id,
            },
            new UserLanguage(){
                UserId = UserTypeConfiguration.DefaultUser.Id,
                LanguageId = LanguageTypeConfguration.DefaultLanguages[2].Id,
                LevelId = LevelTypeConfiguration.DefaultLevels[1].Id,
            }
        ];
    }
}