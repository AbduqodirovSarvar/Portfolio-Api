using Domain.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class UserLanguage : BaseEntity
    {
        public Guid UserId { get; set; }
        public User? User { get; set; }
        public Guid LanguageId { get; set; }
        public Language? Language { get; set; }
        public Guid LevelId { get; set; }
        public Level? Level { get; set; }
    }
}
