using Domain.Entities;
using Infrastructure.Configurations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Db.DefaultInformations
{
    internal class DefaultUserLanguageData
    {
        public static readonly List<UserLanguage> DefaultUserLanguages = [
            new UserLanguage(){
                UserId = DefaultUserData.DefaultUser.Id,
                LanguageId = DefaultLanguageData.DefaultLanguages[0].Id,
                LevelId = DefaultLevelData.DefaultLevels.Last().Id,
            },
            new UserLanguage(){
                UserId = DefaultUserData.DefaultUser.Id,
                LanguageId = DefaultLanguageData.DefaultLanguages[1].Id,
                LevelId = DefaultLevelData.DefaultLevels[3].Id,
            },
            new UserLanguage(){
                UserId = DefaultUserData.DefaultUser.Id,
                LanguageId = DefaultLanguageData.DefaultLanguages[2].Id,
                LevelId = DefaultLevelData.DefaultLevels[1].Id,
            }
        ];
    }
}
