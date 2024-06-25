using Domain.Entities;
using Infrastructure.Configurations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Db.DefaultInformations
{
    internal class DefaultUserExperienceData
    {
        internal static readonly List<UserExperience> DefaultUserExperience = [
            new UserExperience(){
                UserId = DefaultUserData.DefaultUser.Id,
                CompanyId = DefaultCompanyData.DefaultCompanies[0].Id,
                WorkTypeId = DefaultWorkTypeData.DefaultWorkTypes[0].Id,
                PositionId = DefaultPositionData.DefaultPositions[0].Id,
            },
            new UserExperience(){
                UserId = DefaultUserData.DefaultUser.Id,
                CompanyId = DefaultCompanyData.DefaultCompanies[1].Id,
                WorkTypeId = DefaultWorkTypeData.DefaultWorkTypes[1].Id,
                PositionId = DefaultPositionData.DefaultPositions[0].Id,
            }
        ];
    }
}
