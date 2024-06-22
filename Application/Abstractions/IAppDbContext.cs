using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Abstractions
{
    public interface IAppDbContext
    {
        DbSet<User> Users { get; set; }
        DbSet<Country> Countries { get; set; }
        DbSet<City> Cities { get; set; }
        DbSet<Company> Companies { get; set; }
        DbSet<Education> Educations { get; set; }
        DbSet<Language> Languages { get; set; }
        DbSet<Level> Levels { get; set; }
        DbSet<Position> Positions { get; set; }
        DbSet<Skill> Skills { get; set; }
        DbSet<SocialNetwork> SocialNetworks { get; set; }
        DbSet<UITheme> Themes { get; set; }
        DbSet<WorkType> WorkTypes { get; set; }
        DbSet<UserCertificate> UserCertificates { get; set; }
        DbSet<UserEducation> UserEducations { get; set; }
        DbSet<UserExperience> UserExperiences { get; set; }
        DbSet<UserLanguage> UserLanguages { get; set; }
        DbSet<UserProject> UserProjects { get; set; }
        DbSet<UserSkill> UserSkills { get; set; }
        DbSet<UserSocialNetwork> UserSocialNetworks { get; set; }

        Task<int> SaveChangesAsync(CancellationToken cancellationToken = default);
    }
}
