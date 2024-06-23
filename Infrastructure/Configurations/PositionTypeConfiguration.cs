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
    public class PositionTypeConfiguration : LocalizableWithDescriptionEntityTypeConfiguration<Position>
    {
        public override void Configure(EntityTypeBuilder<Position> builder)
        {
            base.Configure(builder);
            builder.HasData([.. DefaultPositions]);
        }

        public static readonly List<Position> DefaultPositions = [
            new Position
            {
                Name = "Backend Developer",
                NameUz = "Backend dasturchi",
                NameEn = "Backend Developer",
                NameRu = "Бэкенд разработчик",
                Description = "Develops and maintains the server-side logic of web applications.",
                DescriptionUz = "Veb ilovalar server tomonidagi logikasini rivojlantirish va saqlash.",
                DescriptionEn = "Develops and maintains the server-side logic of web applications.",
                DescriptionRu = "Разрабатывает и поддерживает серверную логику веб-приложений."
            },
            new Position
            {
                Name = "Frontend Developer",
                NameUz = "Frontend dasturchi",
                NameEn = "Frontend Developer",
                NameRu = "Фронтенд разработчик",
                Description = "Builds and maintains the client-side of web applications.",
                DescriptionUz = "Veb ilovalarning mijoz tomonini yaratish va saqlash.",
                DescriptionEn = "Builds and maintains the client-side of web applications.",
                DescriptionRu = "Строит и поддерживает клиентскую часть веб-приложений."
            },
            new Position
            {
                Name = "System Administrator",
                NameUz = "Tizim administratori",
                NameEn = "System Administrator",
                NameRu = "Системный администратор",
                Description = "Responsible for maintaining and managing computer systems and networks within an organization.",
                DescriptionUz = "Tashkilot ichidagi kompyuter tizimlari va tarmoqlarni saqlash va boshqarishdan mas'ul.",
                DescriptionEn = "Responsible for maintaining and managing computer systems and networks within an organization.",
                DescriptionRu = "Ответственен за поддержание и управление компьютерными системами и сетями в организации."
            },
            new Position
            {
                Name = "Network Engineer",
                NameUz = "Tarmoq muhandisi",
                NameEn = "Network Engineer",
                NameRu = "Сетевой инженер",
                Description = "Designs, implements, and manages data communication networks such as LANs and WANs.",
                DescriptionUz = "Mahalliy tarmoqlar (LAN) va keng sahalar (WAN) kabi ma'lumotlar almashish tarmoqlarini dizayn qilish, amalga oshirish va boshqarish.",
                DescriptionEn = "Designs, implements, and manages data communication networks such as LANs and WANs.",
                DescriptionRu = "Проектирует, внедряет и управляет сетями передачи данных, такими как LAN и WAN."
            },
            new Position
            {
                Name = "IT Security Analyst",
                NameUz = "IT Xavfsizlik tahliliy",
                NameEn = "IT Security Analyst",
                NameRu = "Аналитик информационной безопасности",
                Description = "Monitors and protects an organization's computer systems and networks from cyber threats and attacks.",
                DescriptionUz = "Tashkilotning kompyuter tizimlarini va tarmoqlarini onlayn xavf va hujumlaridan himoya qilish va nazorat qilish.",
                DescriptionEn = "Monitors and protects an organization's computer systems and networks from cyber threats and attacks.",
                DescriptionRu = "Мониторит и защищает компьютерные системы и сети организации от киберугроз и атак."
            },
            new Position
            {
                Name = "Database Administrator",
                NameUz = "Ma'lumotlar bazasi administratori",
                NameEn = "Database Administrator",
                NameRu = "Администратор баз данных",
                Description = "Manages and maintains an organization's database systems, ensuring data security, integrity, and availability.",
                DescriptionUz = "Tashkilotning ma'lumotlar bazasini boshqarish va saqlash, ma'lumotlarni xavfsizligini, integritetini va mavjudligini ta'minlashdan mas'ul.",
                DescriptionEn = "Manages and maintains an organization's database systems, ensuring data security, integrity, and availability.",
                DescriptionRu = "Управляет и поддерживает базы данных организации, обеспечивая безопасность, целостность и доступность данных."
            },
            new Position
            {
                Name = "IT Support Specialist",
                NameUz = "IT qo'llab-quvvat mutaxassis",
                NameEn = "IT Support Specialist",
                NameRu = "Специалист по поддержке IT",
                Description = "Provides technical support and troubleshooting for IT systems and end-users within an organization.",
                DescriptionUz = "Tashkilot ichidagi IT tizimlari va foydalanuvchilar uchun texnik yordam va muammolar hal qilishni ta'minlash.",
                DescriptionEn = "Provides technical support and troubleshooting for IT systems and end-users within an organization.",
                DescriptionRu = "Обеспечивает техническую поддержку и устранение неполадок для IT систем и конечных пользователей в организации."
            },
            new Position
            {
                Name = "IT Project Manager",
                NameUz = "IT loyihalash boshqaruvi",
                NameEn = "IT Project Manager",
                NameRu = "Менеджер IT проектов",
                Description = "Plans, organizes, and oversees IT projects, ensuring they are completed on time, within budget, and meet organizational requirements.",
                DescriptionUz = "IT loyihalarini rejalashtirish, tashkil etish va boshqarish vaqti, byudjeti va tashkilot talablari bilan mos keladiganligini ta'minlash.",
                DescriptionEn = "Plans, organizes, and oversees IT projects, ensuring they are completed on time, within budget, and meet organizational requirements.",
                DescriptionRu = "Планирует, организует и контролирует IT проекты, обеспечивая их выполнение в срок, в рамках бюджета и в соответствии с требованиями организации."
            },
            new Position
            {
                Name = "DevOps Engineer",
                NameUz = "DevOps muhandisi",
                NameEn = "DevOps Engineer",
                NameRu = "Инженер DevOps",
                Description = "Combines software development (Dev) and IT operations (Ops), ensuring continuous integration and delivery of software.",
                DescriptionUz = "Dastur ishlab chiqarish (Dev) va IT operatsiyalari (Ops)ni birlashtirib, dasturiy ta'minotlarni doimiy integratsiyasi va taqdimoti ta'minlash.",
                DescriptionEn = "Combines software development (Dev) and IT operations (Ops), ensuring continuous integration and delivery of software.",
                DescriptionRu = "Комбинирует разработку программного обеспечения (Dev) и операции IT (Ops), обеспечивая непрерывную интеграцию и доставку программного обеспечения."
            },
            new Position
            {
                Name = "Data Scientist",
                NameUz = "Ma'lumot olimi",
                NameEn = "Data Scientist",
                NameRu = "Специалист по анализу данных",
                Description = "Analyzes complex data sets to help organizations make informed decisions.",
                DescriptionUz = "Tashkilotlarga ma'lumotlardan foydalanishda yordam berish uchun murakkab ma'lumot to'plamlarini tahlil qiladi.",
                DescriptionEn = "Analyzes complex data sets to help organizations make informed decisions.",
                DescriptionRu = "Анализирует сложные наборы данных, чтобы помочь организациям принимать обоснованные решения."
            },
            new Position
            {
                Name = "UX/UI Designer",
                NameUz = "UX/UI dizayneri",
                NameEn = "UX/UI Designer",
                NameRu = "Дизайнер UX/UI",
                Description = "Designs user experiences and user interfaces for digital products to enhance user satisfaction.",
                DescriptionUz = "Foydalanuvchi tajribalarini va raqamli mahsulotlar uchun foydalanuvchi interfeyslarini dizayn qilish, foydalanuvchining qoniqishini oshirish.",
                DescriptionEn = "Designs user experiences and user interfaces for digital products to enhance user satisfaction.",
                DescriptionRu = "Проектирует пользовательские интерфейсы и интерфейсы пользователя для цифровых продуктов для улучшения удовлетворенности пользователя."
            }
        ];

    }
}
