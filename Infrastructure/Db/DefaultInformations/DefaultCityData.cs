using Domain.Entities;
using Infrastructure.Configurations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Db.DefaultInformations
{
    internal class DefaultCityData
    {
        internal static readonly List<City> DefaultCities = [
            new City
                {
                    CountyId = DefaultCountryData.Countries[0].Id,
                    Name = "Tashkent",
                    NameUz = "Toshkent",
                    NameEn = "Tashkent",
                    NameRu = "Ташкент"
                },
                new City
                {
                    CountyId = DefaultCountryData.Countries[0].Id,
                    Name = "Namangan",
                    NameUz = "Namangan",
                    NameEn = "Namangan",
                    NameRu = "Наманган"
                },
                new City
                {
                    CountyId = DefaultCountryData.Countries[0].Id,
                    Name = "Samarkand",
                    NameUz = "Samarqand",
                    NameEn = "Samarkand",
                    NameRu = "Самарканд"
                },
                new City
                {
                    CountyId = DefaultCountryData.Countries[0].Id,
                    Name = "Andijan",
                    NameUz = "Andijon",
                    NameEn = "Andijan",
                    NameRu = "Андижан"
                },
                new City
                {
                    CountyId = DefaultCountryData.Countries[0].Id,
                    Name = "Nukus",
                    NameUz = "Nukus",
                    NameEn = "Nukus",
                    NameRu = "Нукус"
                },
                new City
                {
                    CountyId = DefaultCountryData.Countries[0].Id,
                    Name = "Fergana",
                    NameUz = "Farg'ona",
                    NameEn = "Fergana",
                    NameRu = "Фергана"
                },
                new City
                {
                    CountyId = DefaultCountryData.Countries[0].Id,
                    Name = "Bukhara",
                    NameUz = "Buxoro",
                    NameEn = "Bukhara",
                    NameRu = "Бухара"
                },
                new City
                {
                    CountyId = DefaultCountryData.Countries[0].Id,
                    Name = "Qarshi",
                    NameUz = "Qarshi",
                    NameEn = "Qarshi",
                    NameRu = "Карши"
                },
                new City
                {
                    CountyId = DefaultCountryData.Countries[0].Id,
                    Name = "Kokand",
                    NameUz = "Qo'qon",
                    NameEn = "Kokand",
                    NameRu = "Коканд"
                },
                new City
                {
                    CountyId = DefaultCountryData.Countries[0].Id,
                    Name = "Margilan",
                    NameUz = "Marg'ilon",
                    NameEn = "Margilan",
                    NameRu = "Маргилан"
                },
                new City
                {
                    CountyId = DefaultCountryData.Countries[0].Id,
                    Name = "Termez",
                    NameUz = "Termiz",
                    NameEn = "Termez",
                    NameRu = "Термез"
                },
                new City
                {
                    CountyId = DefaultCountryData.Countries[0].Id,
                    Name = "Jizzakh",
                    NameUz = "Jizzax",
                    NameEn = "Jizzakh",
                    NameRu = "Джизак"
                },
                new City
                {
                    CountyId = DefaultCountryData.Countries[0].Id,
                    Name = "Angren",
                    NameUz = "Angren",
                    NameEn = "Angren",
                    NameRu = "Ангрен"
                },
                new City
                {
                    CountyId = DefaultCountryData.Countries[0].Id,
                    Name = "Chirchiq",
                    NameUz = "Chirchiq",
                    NameEn = "Chirchiq",
                    NameRu = "Чирчик"
                },
                new City
                {
                    CountyId = DefaultCountryData.Countries[0].Id,
                    Name = "Navoiy",
                    NameUz = "Navoiy",
                    NameEn = "Navoiy",
                    NameRu = "Навоий"
                },
                new City
                {
                    CountyId = DefaultCountryData.Countries[0].Id,
                    Name = "Urgench",
                    NameUz = "Urganch",
                    NameEn = "Urgench",
                    NameRu = "Ургенч"
                },
                new City
                {
                    CountyId = DefaultCountryData.Countries[0].Id,
                    Name = "Shahrisabz",
                    NameUz = "Shahrisabz",
                    NameEn = "Shahrisabz",
                    NameRu = "Шахрисабз"
                },
                new City
                {
                    CountyId = DefaultCountryData.Countries[0].Id,
                    Name = "Olmaliq",
                    NameUz = "Olmaliq",
                    NameEn = "Olmaliq",
                    NameRu = "Олмалиқ"
                },
                new City
                {
                    CountyId = DefaultCountryData.Countries[0].Id,
                    Name = "Bekobod",
                    NameUz = "Bekobod",
                    NameEn = "Bekobod",
                    NameRu = "Бекобод"
                },

            // Kazakhstan cities ...

            new City
                {
                    CountyId= DefaultCountryData.Countries[1].Id,
                    Name = "Almaty",
                    NameUz = "Almaty",
                    NameEn = "Almaty",
                    NameRu = "Алматы"
                },
                new City
                {
                    CountyId= DefaultCountryData.Countries[1].Id,
                    Name = "Nur-Sultan",
                    NameUz = "Nur-Sultan",
                    NameEn = "Nur-Sultan",
                    NameRu = "Нур-Султан"
                },
                new City
                {
                    CountyId= DefaultCountryData.Countries[1].Id,
                    Name = "Shymkent",
                    NameUz = "Shymkent",
                    NameEn = "Shymkent",
                    NameRu = "Шымкент"
                },
                new City
                {
                    CountyId= DefaultCountryData.Countries[1].Id,
                    Name = "Karaganda",
                    NameUz = "Karaganda",
                    NameEn = "Karaganda",
                    NameRu = "Караганда"
                },
                new City
                {
                    CountyId= DefaultCountryData.Countries[1].Id,
                    Name = "Aktobe",
                    NameUz = "Aktobe",
                    NameEn = "Aktobe",
                    NameRu = "Актобе"
                },
                new City
                {
                    CountyId= DefaultCountryData.Countries[1].Id,
                    Name = "Taraz",
                    NameUz = "Taraz",
                    NameEn = "Taraz",
                    NameRu = "Тараз"
                },
                new City
                {
                    CountyId= DefaultCountryData.Countries[1].Id,
                    Name = "Pavlodar",
                    NameUz = "Pavlodar",
                    NameEn = "Pavlodar",
                    NameRu = "Павлодар"
                },
                new City
                {
                    CountyId= DefaultCountryData.Countries[1].Id,
                    Name = "Ust-Kamenogorsk",
                    NameUz = "Ust-Kamenogorsk",
                    NameEn = "Ust-Kamenogorsk",
                    NameRu = "Усть-Каменогорск"
                },
                new City
                {
                    CountyId= DefaultCountryData.Countries[1].Id,
                    Name = "Semey",
                    NameUz = "Semey",
                    NameEn = "Semey",
                    NameRu = "Семей"
                },
                new City
                {
                    CountyId= DefaultCountryData.Countries[1].Id,
                    Name = "Kostanay",
                    NameUz = "Kostanay",
                    NameEn = "Kostanay",
                    NameRu = "Костанай"
                },
                new City
                {
                    CountyId= DefaultCountryData.Countries[1].Id,
                    Name = "Petropavl",
                    NameUz = "Petropavl",
                    NameEn = "Petropavl",
                    NameRu = "Петропавловск"
                },
                new City
                {
                    CountyId= DefaultCountryData.Countries[1].Id,
                    Name = "Oral",
                    NameUz = "Oral",
                    NameEn = "Oral",
                    NameRu = "Уральск"
                },
                new City
                {
                    CountyId= DefaultCountryData.Countries[1].Id,
                    Name = "Kyzylorda",
                    NameUz = "Kyzylorda",
                    NameEn = "Kyzylorda",
                    NameRu = "Кызылорда"
                },
                new City
                {
                    CountyId= DefaultCountryData.Countries[1].Id,
                    Name = "Atyrau",
                    NameUz = "Atyrau",
                    NameEn = "Atyrau",
                    NameRu = "Атырау"
                },
                new City
                {
                    CountyId= DefaultCountryData.Countries[1].Id,
                    Name = "Temirtau",
                    NameUz = "Temirtau",
                    NameEn = "Temirtau",
                    NameRu = "Темиртау"
                },
                new City
                {
                    CountyId= DefaultCountryData.Countries[1].Id,
                    Name = "Aktau",
                    NameUz = "Aktau",
                    NameEn = "Aktau",
                    NameRu = "Актау"
                },
                new City
                {
                    CountyId= DefaultCountryData.Countries[1].Id,
                    Name = "Balqash",
                    NameUz = "Balqash",
                    NameEn = "Balqash",
                    NameRu = "Балхаш"
                },
                new City
                {
                    CountyId= DefaultCountryData.Countries[1].Id,
                    Name = "Kokshetau",
                    NameUz = "Kokshetau",
                    NameEn = "Kokshetau",
                    NameRu = "Кокшетау"
                },
                new City
                {
                    CountyId= DefaultCountryData.Countries[1].Id,
                    Name = "Taldykorgan",
                    NameUz = "Taldykorgan",
                    NameEn = "Taldykorgan",
                    NameRu = "Талдыкорган"
                },
                new City
                {
                    CountyId= DefaultCountryData.Countries[1].Id,
                    Name = "Kyzyl-Orda",
                    NameUz = "Kyzyl-Orda",
                    NameEn = "Kyzyl-Orda",
                    NameRu = "Кызылорда"
                },
            ];
    }
}
