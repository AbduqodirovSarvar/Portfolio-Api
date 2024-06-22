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
    public class CompanyTypeConfiguration : BaseEntityTypeConfiguration<Company>
    {
        public override void Configure(EntityTypeBuilder<Company> builder)
        {
            base.Configure(builder);
            builder.HasIndex(x => new { x.CityId, x.Name, x.NameEn, x.NameUz, x.NameRu, x.Description, x.DescriptionEn, x.DescriptionRu, x.DescriptionUz });
            builder.HasData([.. DefaultCompanies]);
        }

        public static readonly List<Company> DefaultCompanies = [
            new Company
            {
                CityId = CityTypeConfiguration.UzbekistanCities[0].Id,
                Name = "ITransition",
                NameUz = "ITransition",
                NameEn = "ITransition",
                NameRu = "ITransition",
                Description = "ITransition is a global provider of software development, QA, and consulting services with a focus on advanced technologies.",
                DescriptionUz = "ITransition yuqori texnologiyalar ustida qurilgan dasturlar va ilovalarni rivojlantirish, QA va konsalting xizmatlari taqdim etuvchi global kompaniyadir.",
                DescriptionEn = "ITransition is a global provider of software development, QA, and consulting services with a focus on advanced technologies.",
                DescriptionRu = "ITransition — международный поставщик услуг по разработке программного обеспечения, QA и консалтинга с акцентом на передовые технологии."
            },
            new Company
            {
                CityId = CityTypeConfiguration.UzbekistanCities[0].Id,
                Name = "BePro-DEVHUB",
                NameUz = "BePro-DEVHUB",
                NameEn = "BePro-DEVHUB",
                NameRu = "BePro-DEVHUB",
                Description = "BePro-DEVHUB is a software development and IT consulting company specializing in web and mobile app development.",
                DescriptionUz = "BePro-DEVHUB veb va mobil ilovalar dasturlashida ihtisoslashgan dasturiy ta'minot va IT konsalting kompaniyasidir.",
                DescriptionEn = "BePro-DEVHUB is a software development and IT consulting company specializing in web and mobile app development.",
                DescriptionRu = "BePro-DEVHUB — это компания по разработке программного обеспечения и IT-консалтингу, специализирующаяся на разработке веб и мобильных приложений."
            },
            new Company
            {
                CityId = CityTypeConfiguration.UzbekistanCities[0].Id,
                Name = "EPAM",
                NameUz = "EPAM",
                NameEn = "EPAM",
                NameRu = "EPAM",
                Description = "EPAM Systems is a leading global provider of digital platform engineering and software development services.",
                DescriptionUz = "EPAM Systems dunyoning eng yuqori darajadagi raqamli platforma injenerlik va dasturlash xizmatlari taqdim etuvchi global tajribali kompaniyadir.",
                DescriptionEn = "EPAM Systems is a leading global provider of digital platform engineering and software development services.",
                DescriptionRu = "EPAM Systems — ведущий мировой поставщик цифровой платформенной инженерии и разработки программного обеспечения."
            },
            new Company
            {
                CityId = CityTypeConfiguration.UzbekistanCities[0].Id,
                Name = "EXADEL",
                NameUz = "EXADEL",
                NameEn = "EXADEL",
                NameRu = "EXADEL",
                Description = "Exadel is a global software engineering company that provides full-cycle software development, QA, and testing services.",
                DescriptionUz = "Exadel global dasturiy injinerlik kompaniyasi, to'liq tsikl dasturiy ta'minot, QA va sinov xizmatlari taqdim etadi.",
                DescriptionEn = "Exadel is a global software engineering company that provides full-cycle software development, QA, and testing services.",
                DescriptionRu = "Exadel — это международная компания по разработке программного обеспечения, предоставляющая полный цикл разработки ПО, QA и тестирования."
            },
        ];
    }
}
