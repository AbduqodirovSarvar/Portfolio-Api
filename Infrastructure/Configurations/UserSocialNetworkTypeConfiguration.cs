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
    public class UserSocialNetworkTypeConfiguration : BaseEntityTypeConfiguration<UserSocialNetwork>
    {
        public override void Configure(EntityTypeBuilder<UserSocialNetwork> builder)
        {
            base.Configure(builder);
            builder.HasOne(x => x.SocialNetwork).WithMany().HasForeignKey(x => x.SocialNetworkId);
            builder.HasIndex(x => new { x.UserId, x.SocialNetworkId }).IsUnique();
            builder.HasIndex(x => x.Url).IsUnique();
            builder.HasData([.. DefaultUserSocialNetworks]);
        }

        public static readonly List<UserSocialNetwork> DefaultUserSocialNetworks = [
                new UserSocialNetwork(){
                    UserId = UserTypeConfiguration.DefaultUser.Id,
                    SocialNetworkId = SocialNetworkTypeConfiguration.DefaultSocialNetworks[0].Id,
                    Url = "https://t.me/Sarvarbek_Abduqodirov"
                },
                new UserSocialNetwork(){
                    UserId = UserTypeConfiguration.DefaultUser.Id,
                    SocialNetworkId = SocialNetworkTypeConfiguration.DefaultSocialNetworks[1].Id,
                    Url = "https://www.linkedin.com/in/abduqodirov-sarvarbek/"
                },
                new UserSocialNetwork(){
                    UserId = UserTypeConfiguration.DefaultUser.Id,
                    SocialNetworkId = SocialNetworkTypeConfiguration.DefaultSocialNetworks[2].Id,
                    Url = "https://github.com/AbduqodirovSarvar"
                },
                new UserSocialNetwork(){
                    UserId = UserTypeConfiguration.DefaultUser.Id,
                    SocialNetworkId = SocialNetworkTypeConfiguration.DefaultSocialNetworks[3].Id,
                    Url = "https://gitlab.com/Abduqodirov_Sarvar"
                }
            ];
    }
}
