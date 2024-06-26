﻿using Domain.Entities;
using Infrastructure.Configurations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Db.DefaultInformations
{
    internal static class DefaultEducationData
    {
        internal static readonly List<Education> DefaultEducations = [
            new Education(){
                CityId = DefaultCityData.DefaultCities[0].Id,
                Name = "Tashkent University of Information Technologies",
                NameUz = "Toshkent axborot texnologiyalari universiteti",
                NameEn = "Tashkent University of Information Technologies",
                NameRu = "Ташкентский университет информационных технологий",
                Description = "Tashkent University of Information Technologies (TUIT) is a leading educational institution in Uzbekistan specializing in IT and related fields.",
                DescriptionUz = "Toshkent axborot texnologiyalari universiteti (TATU) O'zbekistonda IT va undan qo'shimcha sohalar bo'yicha yetakchi ta'lim muassasasi hisoblanadi.",
                DescriptionEn = "Tashkent University of Information Technologies (TUIT) is a leading educational institution in Uzbekistan specializing in IT and related fields.",
                DescriptionRu = "Ташкентский университет информационных технологий (ТАТУ) является ведущим образовательным учреждением в Узбекистане, специализирующимся в области ИТ и смежных направлений.",
                },
            new Education(){
                CityId = DefaultCityData.DefaultCities[0].Id,
                Name = "Najot Ta'lim IT Academy",
                NameUz = "Najot Ta'lim IT Akademiyasi",
                NameEn = "Najot Ta'lim IT Academy",
                NameRu = "IT-академия «Наджот Таълим»",
                Description = "Najot Ta'lim IT Academy is an educational institution in Uzbekistan that specializes in IT education and training.",
                DescriptionUz = "Najot Ta'lim IT Akademiyasi O'zbekistonda IT ta'limi va tayyorlash sohasiga ixtisoslashgan ta'lim muassasasi.",
                DescriptionEn = "Najot Ta'lim IT Academy is an educational institution in Uzbekistan that specializes in IT education and training.",
                DescriptionRu = "IT-академия «Наджот Таълим» - образовательное учреждение в Узбекистане, специализирующееся на образовании и тренинге в области информационных технологий.",
                }
            ];
    }
}
