using Application.Abstractions;
using Domain.Abstractions;
using Domain.Abstractions.Interfaces;
using Domain.Entities;
using Infrastructure.Configurations;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Db
{
    public class AppDbContext(DbContextOptions<AppDbContext> options, ICurrentUserService currentUserService) : DbContext(options), IAppDbContext
    {
        private readonly ICurrentUserService _currentUserService =currentUserService;

        public DbSet<User> Users { get; set; }
        public DbSet<Country> Countries { get; set; }
        public DbSet<City> Cities { get; set; }
        public DbSet<Company> Companies { get; set; }
        public DbSet<Education> Educations { get; set; }
        public DbSet<Language> Languages { get; set; }
        public DbSet<Level> Levels { get; set; }
        public DbSet<Position> Positions { get; set; }
        public DbSet<Skill> Skills { get; set; }
        public DbSet<SocialNetwork> SocialNetworks { get; set; }
        public DbSet<UITheme> Themes { get; set; }
        public DbSet<WorkType> WorkTypes { get; set; }
        public DbSet<UserCertificate> UserCertificates { get; set; }
        public DbSet<UserEducation> UserEducations { get; set; }
        public DbSet<UserExperience> UserExperiences { get; set; }
        public DbSet<UserLanguage> UserLanguages { get; set; }
        public DbSet<UserProject> UserProjects { get; set; }
        public DbSet<UserSkill> UserSkills { get; set; }
        public DbSet<UserSocialNetwork> UserSocialNetworks { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.EnableSensitiveDataLogging();
        }

        public override Task<int> SaveChangesAsync(CancellationToken cancellationToken = default)
        {
            SetAuditableEntity();
            return base.SaveChangesAsync(cancellationToken);
        }

        public async Task Seed()
        {
            using var _context = this.GetService<AppDbContext>();

            _context.Countries.AddRange(DefaultInformations.DefaultCountryData.Countries);
            _context.Languages.AddRange(DefaultInformations.DefaultLanguageData.DefaultLanguages);
            _context.Levels.AddRange(DefaultInformations.DefaultLevelData.DefaultLevels);
            _context.Positions.AddRange(DefaultInformations.DefaultPositionData.DefaultPositions);
            _context.SocialNetworks.AddRange(DefaultInformations.DefaultSocialNetworkData.DefaultSocialNetworks);
            _context.WorkTypes.AddRange(DefaultInformations.DefaultWorkTypeData.DefaultWorkTypes);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            _context.Cities.AddRange(DefaultInformations.DefaultCityData.DefaultCities);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            _context.Users.Add(DefaultInformations.DefaultUserData.DefaultUser);
            _context.Educations.AddRange(DefaultInformations.DefaultEducationData.DefaultEducations);
            _context.Companies.AddRange(DefaultInformations.DefaultCompanyData.DefaultCompanies);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            _context.UserEducations.AddRange(DefaultInformations.DefaultUserEducationData.DefaultUserEducations);
            _context.UserExperiences.AddRange(DefaultInformations.DefaultUserExperienceData.DefaultUserExperience);
            _context.UserLanguages.AddRange(DefaultInformations.DefaultUserLanguageData.DefaultUserLanguages);
            _context.UserSocialNetworks.AddRange(DefaultInformations.DefaultUserSocialNetworkData.DefaultUserSocialNetworks);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }

        private void SetAuditableEntity()
        {
            foreach (var entry in ChangeTracker.Entries<BaseEntity>())
            {
                if (entry.State == EntityState.Added)
                {
                    entry.Entity.Id = Guid.NewGuid();
                    entry.Entity.CreatedById = _currentUserService.UserId;
                    entry.Entity.CreatedAt = DateTime.UtcNow;
                }
            }
        }
    }
}
