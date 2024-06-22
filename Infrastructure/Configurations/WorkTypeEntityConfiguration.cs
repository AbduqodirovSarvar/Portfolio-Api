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
    public class WorkTypeEntityConfiguration : LocalizableWithDescriptionEntityTypeConfiguration<WorkType>
    {
        public override void Configure(EntityTypeBuilder<WorkType> builder)
        {
            base.Configure(builder);
            builder.HasData([.. DefaultWorkTypes]);
        }

        public static readonly List<WorkType> DefaultWorkTypes = [
            new WorkType
            {
                Name = "Intern",
                NameUz = "Stajyor",
                NameEn = "Intern",
                NameRu = "Стажер",
                Description = "A student or trainee who works in a company to gain work experience.",
                DescriptionUz = "Ish tajribasini olish uchun kompaniyada ishlovchi talaba yoki o'quvchi.",
                DescriptionEn = "A student or trainee who works in a company to gain work experience.",
                DescriptionRu = "Студент или стажер, который работает в компании для получения опыта работы."
            },
            new WorkType
            {
                Name = "Full-time",
                NameUz = "To'la vaqti",
                NameEn = "Full-time",
                NameRu = "Полный рабочий день",
                Description = "Employee works a standard number of hours per week as defined by the employer.",
                DescriptionUz = "Ishchi ish haftada ish joyi tomonidan belgilangan standart soatlar bo'yicha ishlaydi.",
                DescriptionEn = "Employee works a standard number of hours per week as defined by the employer.",
                DescriptionRu = "Сотрудник работает стандартное количество часов в неделю, определенное работодателем."
            },
            new WorkType
            {
                Name = "Part-time",
                NameUz = "Qisman ish",
                NameEn = "Part-time",
                NameRu = "Неполный рабочий день",
                Description = "Employee works fewer hours than a full-time employee.",
                DescriptionUz = "Ishchi to'la vaqtli ishchidan kam soat ishlaydi.",
                DescriptionEn = "Employee works fewer hours than a full-time employee.",
                DescriptionRu = "Сотрудник работает меньше часов, чем на полный рабочий день."
            },
            new WorkType
            {
                Name = "Remote",
                NameUz = "Masofaviy",
                NameEn = "Remote",
                NameRu = "Удаленная работа",
                Description = "Employee works from a location other than the office.",
                DescriptionUz = "Ishchi ofisdan boshqa joydan ishlaydi.",
                DescriptionEn = "Employee works from a location other than the office.",
                DescriptionRu = "Сотрудник работает не в офисе, а на удаленной основе."
            },
        ];
    }
}
