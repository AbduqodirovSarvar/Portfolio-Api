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
    public class LanguageTypeConfguration : IEntityTypeConfiguration<Language>
    {
        public void Configure(EntityTypeBuilder<Language> builder)
        {
            builder.HasData([.. DefaultLanguages]);
        }

        public static readonly List<Language> DefaultLanguages = [
                new Language(){
                    Name = "Uzbek",
                    NameUz = "O'zbekcha",
                    NameEn = "Uzbek",
                    NameRu = "Узбекский",
                },
                new Language(){
                    Name = "English",
                    NameUz = "Inglizcha",
                    NameEn = "English",
                    NameRu = "Английский",
                },
                new Language(){
                    Name = "Russian",
                    NameUz = "Ruscha",
                    NameEn = "Russian",
                    NameRu = "Русский",
                }
            ];
    }
}
