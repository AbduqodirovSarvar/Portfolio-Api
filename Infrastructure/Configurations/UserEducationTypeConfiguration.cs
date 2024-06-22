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
    public class UserEducationTypeConfiguration : BaseEntityTypeConfiguration<UserEducation>
    {
        public override void Configure(EntityTypeBuilder<UserEducation> builder)
        {
            base.Configure(builder);
            builder.HasOne(x => x.User).WithMany(x => x.Educations).HasForeignKey(x => x.UserId);
            builder.HasOne(x => x.Education).WithMany().HasForeignKey(x => x.EducationId);
            builder.HasData([.. DefaultUserEducations]);
        }

        public static readonly List<UserEducation> DefaultUserEducations = [
                new UserEducation(){
                    UserId = UserTypeConfiguration.DefaultUser.Id,
                    EducationId = EducationTypeConfiguration.DefaultEducations[0].Id,
                    From = new DateOnly(2020, 09, 4),
                    To = new DateOnly(2024, 06,15)
                },
                new UserEducation(){
                    UserId = UserTypeConfiguration.DefaultUser.Id,
                    EducationId = EducationTypeConfiguration.DefaultEducations[1].Id,
                    From = new DateOnly(2022, 07, 01),
                    To = new DateOnly(2023, 04, 30)
                }
            ];
    }
}
