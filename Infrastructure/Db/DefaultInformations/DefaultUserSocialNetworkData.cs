using Domain.Entities;
using Infrastructure.Configurations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Db.DefaultInformations
{
    internal class DefaultUserSocialNetworkData
    {
        public static readonly List<UserSocialNetwork> DefaultUserSocialNetworks = [
                new UserSocialNetwork(){
                    UserId = DefaultUserData.DefaultUser.Id,
                    SocialNetworkId = DefaultSocialNetworkData.DefaultSocialNetworks[0].Id,
                    Url = "https://t.me/Sarvarbek_Abduqodirov"
                },
                new UserSocialNetwork(){
                    UserId = DefaultUserData.DefaultUser.Id,
                    SocialNetworkId = DefaultSocialNetworkData.DefaultSocialNetworks[1].Id,
                    Url = "https://www.linkedin.com/in/abduqodirov-sarvarbek/"
                },
                new UserSocialNetwork(){
                    UserId = DefaultUserData.DefaultUser.Id,
                    SocialNetworkId = DefaultSocialNetworkData.DefaultSocialNetworks[2].Id,
                    Url = "https://github.com/AbduqodirovSarvar"
                },
                new UserSocialNetwork(){
                    UserId = DefaultUserData.DefaultUser.Id,
                    SocialNetworkId = DefaultSocialNetworkData.DefaultSocialNetworks[3].Id,
                    Url = "https://gitlab.com/Abduqodirov_Sarvar"
                }
            ];
    }
}
