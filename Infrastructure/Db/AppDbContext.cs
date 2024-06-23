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
            using var _context = this.GetService<IAppDbContext>();
           
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
