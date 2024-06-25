using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Db.DefaultInformations
{
    internal class DefaultLevelData
    {
        internal static readonly List<Level> DefaultLevels = [
            new Level(){
                Name = "Beginner",
                NameUz = "Boshlang'ich",
                NameEn = "Beginner",
                NameRu = "Начинающий",
                Description = "Basic understanding of the language with limited vocabulary and simple grammar.",
                DescriptionUz = "O'z tilini boshlang'ich darajada o'rganish, chegaraviy so'zlashish va oddiy grammatikaga ega bo'lish.",
                DescriptionEn = "Basic understanding of the language with limited vocabulary and simple grammar.",
                DescriptionRu = "Основное понимание языка с ограниченным словарным запасом и простой грамматикой."
            },
            new Level(){
                Name = "Elementary",
                NameUz = "O'rtacha",
                NameEn = "Elementary",
                NameRu = "Начальный",
                Description = "Basic comprehension of everyday expressions and simple phrases. Can introduce yourself and ask basic questions about personal information.",
                DescriptionUz = "Kundalik ifodalar va oddiy iboralar o'rnating. O'zingizni tanishtirishingiz va shaxsiy ma'lumotlaringiz haqida oddiy savollar berishingiz mumkin.",
                DescriptionEn = "Basic comprehension of everyday expressions and simple phrases. Can introduce yourself and ask basic questions about personal information.",
                DescriptionRu = "Основное понимание повседневных выражений и простых фраз. Можете представиться и задать базовые вопросы о личной информации."
            },
            new Level(){
                Name = "Intermediate",
                NameUz = "O'rta",
                NameEn = "Intermediate",
                NameRu = "Средний",
                Description = "Can understand the main points of clear standard input on familiar matters. Can produce simple connected text on topics that are familiar or of personal interest.",
                DescriptionUz = "Odatiy masalalar haqida bayonotdan foydalanib, asosiy nuqtalarni tushunish mumkin. Odatiy yoki shaxsiy qiziq mavzularida bog'liq oddiy bog'lanishgan matnlarni yaratish mumkin.",
                DescriptionEn = "Can understand the main points of clear standard input on familiar matters. Can produce simple connected text on topics that are familiar or of personal interest.",
                DescriptionRu = "Можете понять основные моменты понятных стандартных вводов по знакомым вопросам. Можете составить простой связанный текст по темам, которые вам знакомы или интересны лично."
            },
            new Level(){
                Name = "Upper-Intermediate",
                NameUz = "Yuqori o'rta",
                NameEn = "Upper-Intermediate",
                NameRu = "Выше среднего",
                Description = "Can understand the main ideas of complex text on both concrete and abstract topics. Can interact with a degree of fluency and spontaneity that makes regular interaction with native speakers quite possible without strain for either party.",
                DescriptionUz = "Aniq yoki abstrakt mavzularda kompleks matnlarning asosiy o'zini tushunish mumkin. Huddi shaxsiyatli so'zlashish va spantane so'zlashish darajasida soddalik bilan amalga oshirish mumkin, bu esa har ikki taraf uchun ham zo'ravon bo'lishsiz mumkin.",
                DescriptionEn = "Can understand the main ideas of complex text on both concrete and abstract topics. Can interact with a degree of fluency and spontaneity that makes regular interaction with native speakers quite possible without strain for either party.",
                DescriptionRu = "Можете понять основные идеи сложного текста по конкретным и абстрактным темам. Можете взаимодействовать с определенной степенью беглости и спонтанности, что делает регулярное общение с носителями языка возможным без напряжения для обеих сторон."
            },
            new Level(){
                 Name = "Advanced",
                NameUz = "Yuqori",
                NameEn = "Advanced",
                NameRu = "Продвинутый",
                Description = "Can understand a wide range of demanding, longer texts, and recognize implicit meaning. Can express ideas fluently and spontaneously without much obvious searching for expressions.",
                DescriptionUz = "Murakkab va uzun matnlarning keng tarqalgan qatorini tushunish va zimmasiz manoni aniqlash mumkin. Ideyalarni boshqarish uchun shifobaxsh va spantane so'zlashish, tushunarli talab qilmaydi.",
                DescriptionEn = "Can understand a wide range of demanding, longer texts, and recognize implicit meaning. Can express ideas fluently and spontaneously without much obvious searching for expressions.",
                DescriptionRu = "Можете понять широкий круг требовательных, длинных текстов и распознать неявное значение. Можете выражать идеи бегло и спонтанно без явного поиска выражений."
            },
            new Level(){
                Name = "Native",
                NameUz = "Ona tili",
                NameEn = "Native",
                NameRu = "Родной",
                Description = "Has a complete command of the language, including idiomatic expressions and colloquialisms. Speaks the language fluently and accurately.",
                DescriptionUz = "Istiqlolik va umumiy gaplashishdagi ona tili hisoblanadi, so'zlashishga ishonch keltiradi.",
                DescriptionEn = "Has a complete command of the language, including idiomatic expressions and colloquialisms. Speaks the language fluently and accurately.",
                DescriptionRu = "Имеет полное владение языком, включая идиоматические выражения и разговорную речь. Говорит на языке бегло и точно."
                }
            ];
    }
}
