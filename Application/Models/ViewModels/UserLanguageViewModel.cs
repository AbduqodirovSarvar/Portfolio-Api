using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Models.ViewModels
{
    public class UserLanguageViewModel : BaseEntityViewModel
    {
        public Guid UserId { get; set; }
        public Guid LanguageId { get; set; }
        public LanguageViewModel? Language { get; set; }
        public Guid LevelId { get; set; }
        public Level? Level { get; set; }
    }
}
