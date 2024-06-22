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
    public class UserExperienceTypeConfiguration : IEntityTypeConfiguration<UserExperience>
    {
        public void Configure(EntityTypeBuilder<UserExperience> builder)
        {
            builder.HasOne(x => x.User).WithMany(x => x.Experiences).HasForeignKey(x => x.UserId);
            builder.HasOne(x => x.WorkType).WithMany(x => x.UserExperience).HasForeignKey(x => x.WorkTypeId);
            builder.HasOne(x => x.Company).WithMany().HasForeignKey(x => x.CompanyId);
            builder.HasOne(x => x.Position).WithMany().HasForeignKey(x => x.PositionId);
        }

        public static readonly List<UserExperience> DefaultUserExperience = [
            new UserExperience(){
                UserId = UserTypeConfiguration.DefaultUser.Id,
                CompanyId = CompanyTypeConfiguration.DefaultCompanies[0].Id,
                WorkTypeId = WorkTypeEntityConfiguration.DefaultWorkTypes[0].Id,
                PositionId = PositionTypeConfiguration.DefaultPositions[0].Id,
            },
            new UserExperience(){
                UserId = UserTypeConfiguration.DefaultUser.Id,
                CompanyId = CompanyTypeConfiguration.DefaultCompanies[1].Id,
                WorkTypeId = WorkTypeEntityConfiguration.DefaultWorkTypes[1].Id,
                PositionId = PositionTypeConfiguration.DefaultPositions[0].Id,
            }
        ];
    }
}