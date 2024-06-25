using Domain.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class UserSkill : BaseEntity
    {
        public Guid UserId { get; set; }
        public Guid SkillId { get; set; }
        public Skill? Skill { get; set; }
        public string? PhotoName { get; set; }
    }
}
