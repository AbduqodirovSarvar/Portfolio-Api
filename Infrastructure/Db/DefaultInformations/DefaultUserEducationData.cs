using Domain.Entities;
using Infrastructure.Configurations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Db.DefaultInformations
{
    internal class DefaultUserEducationData
    {
        public static readonly List<UserEducation> DefaultUserEducations = [
                new UserEducation(){
                    UserId = DefaultUserData.DefaultUser.Id,
                    EducationId = DefaultEducationData.DefaultEducations[0].Id,
                    From = new DateOnly(2020, 09, 4),
                    To = new DateOnly(2024, 06,15)
                },
                new UserEducation(){
                    UserId = DefaultUserData.DefaultUser.Id,
                    EducationId = DefaultEducationData.DefaultEducations[1].Id,
                    From = new DateOnly(2022, 07, 01),
                    To = new DateOnly(2023, 04, 30)
                }
            ];
    }
}
