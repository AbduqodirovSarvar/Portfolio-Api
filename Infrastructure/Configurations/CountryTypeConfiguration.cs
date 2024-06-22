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
    public class CountryTypeConfiguration : LocalizableEntityTypeConfiguration<Country>
    {
        public override void Configure(EntityTypeBuilder<Country> builder)
        {
            base.Configure(builder);
            builder.HasData([..Countries]);
        }

        public static readonly List<Country> Countries = [
            new Country { Name = "Uzbekistan", NameUz = "O'zbekiston", NameEn = "Uzbekistan", NameRu = "Узбекистан" },
            new Country { Name = "Kazakhstan", NameUz = "Qozog'iston", NameEn = "Kazakhstan", NameRu = "Казахстан" },
            new Country { Name = "Turkmenistan", NameUz = "Turkmaniston", NameEn = "Turkmenistan", NameRu = "Туркменистан" },
            new Country { Name = "Kyrgyzstan", NameUz = "Qirg'iziston", NameEn = "Kyrgyzstan", NameRu = "Киргизия" },
            new Country { Name = "Tajikistan", NameUz = "Tojikiston", NameEn = "Tajikistan", NameRu = "Таджикистан" },
            new Country { Name = "China", NameUz = "Xitoy", NameEn = "China", NameRu = "Китай" },
            new Country { Name = "India", NameUz = "Hindiston", NameEn = "India", NameRu = "Индия" },
            new Country { Name = "Japan", NameUz = "Yaponiya", NameEn = "Japan", NameRu = "Япония" },
            new Country { Name = "South Korea", NameUz = "Janubiy Koreya", NameEn = "South Korea", NameRu = "Южная Корея" },
            new Country { Name = "Vietnam", NameUz = "Vyetnam", NameEn = "Vietnam", NameRu = "Вьетнам" },
            new Country { Name = "Indonesia", NameUz = "Indoneziya", NameEn = "Indonesia", NameRu = "Индонезия" },
            new Country { Name = "Turkey", NameUz = "Turkiya", NameEn = "Turkey", NameRu = "Турция" },
            ];
        
    }
}
