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
    public class UserTypeConfiguration : PersonBaseEntityTypeConfiguration<User>
    {
        public override void Configure(EntityTypeBuilder<User> builder)
        {
            base.Configure(builder);
            builder.HasOne(x => x.Position).WithMany().HasForeignKey(x => x.PositionId);
            builder.HasMany(x => x.Projects).WithOne().HasForeignKey(x => x.UserId);
            builder.HasMany(x => x.Certificates).WithOne().HasForeignKey(x => x.UserId);
            builder.HasMany(x => x.Experiences).WithOne().HasForeignKey(x => x.UserId);
            builder.HasMany(x => x.Languages).WithOne().HasForeignKey(x => x.UserId);
            builder.HasMany(x => x.Skills).WithOne().HasForeignKey (x => x.UserId);
            builder.HasMany(x => x.SocialNetworks).WithOne().HasForeignKey(x => x.UserId);
            builder.HasMany(x => x.Educations).WithOne().HasForeignKey(x => x.UserId);
            builder.HasData(DefaultUser);
        }

        public static readonly User DefaultUser = new()
        {
            Firstname = "Sarvarbek",
            Lastname = "Abduqodirov",
            Middlename = "Xasan o'g'li",
            Gender = Domain.Enums.Gender.Male,
            Birthday = new DateOnly(2002, 03, 16),
            Email = "abduqodirovsarvar.2002@gmail.com",
            Phone = "+998932340316",
            PositionId = PositionTypeConfiguration.DefaultPositions[0].Id,
            PasswordHash = "hnCh7L+J7zhoRIEK6JSlWxRyPG5tWobtZxAFZO/5RwwQ6YK9oKQIm17KFOdH7U1nBt9QXjz7kRWFTOIAnqmnJg==",
            AboutMe = "I am a junior Software Engineer. Skilled and curious young software engineer with 1.5 years of experience in building robust systems using .NET Core on backend and React, Typescript on frontend. Wants to design solid architecture and clean code. Good understanding of object oriented programming and fast learning.",
            CityId = CityTypeConfiguration.UzbekistanCities[0].Id,
            EmailConfirmed = true
        };

    }
}
