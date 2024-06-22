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
    public class SocialNetworkTypeConfiguration : LocalizableEntityTypeConfiguration<SocialNetwork>
    {
        public override void Configure(EntityTypeBuilder<SocialNetwork> builder)
        {
            base.Configure(builder);
            builder.HasData([.. DefaultSocialNetworks]);
        }

        public static readonly List<SocialNetwork> DefaultSocialNetworks = [
            new SocialNetwork
            {
                Name = "Telegram",
                NameUz = "Telegram",
                NameEn = "Telegram",
                NameRu = "Телеграм"
            },
            new SocialNetwork
            {
                Name = "LinkedIn",
                NameUz = "LinkedIn",
                NameEn = "LinkedIn",
                NameRu = "LinkedIn"
            },
            new SocialNetwork
            {
                Name = "GitHub",
                NameUz = "GitHub",
                NameEn = "GitHub",
                NameRu = "GitHub"
            },
            new SocialNetwork
            {
                Name = "GitLab",
                NameUz = "GitLab",
                NameEn = "GitLab",
                NameRu = "GitLab"
            },
            new SocialNetwork
            {
                Name = "Twitter",
                NameUz = "Twitter",
                NameEn = "Twitter",
                NameRu = "Твиттер"
            },
            new SocialNetwork
            {
                Name = "Instagram",
                NameUz = "Instagram",
                NameEn = "Instagram",
                NameRu = "Инстаграм"
            },
            new SocialNetwork
            {
                Name = "Thread",
                NameUz = "Thread",
                NameEn = "Thread",
                NameRu = "Thread"
            },
            new SocialNetwork
            {
                Name = "WhatsUp",
                NameUz = "WhatsUp",
                NameEn = "WhatsApp",
                NameRu = "WhatsApp"
            },
            new SocialNetwork
            {
                Name = "Skype",
                NameUz = "Skype",
                NameEn = "Skype",
                NameRu = "Skype"
            },
            new SocialNetwork
            {
                Name = "Imo",
                NameUz = "Imo",
                NameEn = "Imo",
                NameRu = "Imo"
            },
            new SocialNetwork
            {
                Name = "Zoom",
                NameUz = "Zoom",
                NameEn = "Zoom",
                NameRu = "Zoom"
            }
        ];

    }
}
