using Domain.Entities;
using Domain.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Models.ViewModels
{
    public class UserViewModel : BaseEntityViewModel
    {
        public string Firstname { get; set; } = null!;
        public string Lastname { get; set; } = null!;
        public string? Middlename { get; set; }
        public EnumViewModel? Gender { get; set; }
        public DateOnly Birthday { get; set; }
        public string Email { get; set; } = null!;
        public string Phone { get; set; } = null!;
        public Guid PositionId { get; set; }
        public PositionViewModel? Position { get; set; }
        public string? AboutMe { get; set; }
        public string? PhotoName { get; set; }
        public string? ResumeName { get; set; }
        public Guid? UIThemeId { get; set; }
        public ICollection<UserLanguage> Languages { get; set; } = [];
        public ICollection<UserSkill> Skills { get; set; } = [];
        public ICollection<UserSocialNetwork> SocialNetworks { get; set; } = [];
        public ICollection<UserProject> Projects { get; set; } = [];
        public ICollection<UserExperience> Experiences { get; set; } = [];
        public ICollection<UserEducation> Educations { get; set; } = [];
        public ICollection<UserCertificate> Certificates { get; set; } = [];
    }
}
