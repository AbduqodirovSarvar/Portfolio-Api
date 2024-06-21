using Domain.Abstractions;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class User : PersonBase
    {
        public Guid PositionId { get; set; }
        public Position? Position { get; set; }
        public string PasswordHash { get; set; } = null!;
        public string? AboutMe { get; set; }
        public string? PhotoName { get; set; }
        public string? ResumeName { get; set; }
        public ICollection<UserLanguage> Languages { get; set; } = [];
        public ICollection<UserSkill> Skills { get; set; } = [];
        public ICollection<UserSocialNetwork> SocialNetworks { get; set; } = [];
        public ICollection<UserProject> Projects { get; set; } = [];
        public ICollection<UserExperience> Experiences { get; set; } = [];
        public ICollection<UserEducation> Educations { get; set; } = [];
        public ICollection<UserCertificate> Certificates { get; set; } = [];
    }
}
