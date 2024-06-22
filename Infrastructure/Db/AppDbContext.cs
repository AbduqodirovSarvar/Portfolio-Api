using Application.Abstractions;
using Domain.Entities;
using Infrastructure.Configurations;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Db
{
    public class AppDbContext : DbContext, IAppDbContext
    {

        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options)
        {
        }
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

            ApplyAllConfigurations(modelBuilder);
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.EnableSensitiveDataLogging();
        }

        private void ApplyAllConfigurations(ModelBuilder modelBuilder)
        {
            var applyGenericMethod = typeof(ModelBuilder)
                .GetMethods()
                .First(m => m.Name == nameof(ModelBuilder.ApplyConfiguration)
                            && m.GetParameters().Length == 1);

            var configurations = Assembly.GetExecutingAssembly().GetTypes()
                .Where(t => t.GetInterfaces()
                             .Any(i => i.IsGenericType
                                       && i.GetGenericTypeDefinition() == typeof(IEntityTypeConfiguration<>)))
                .ToList();

            foreach (var config in configurations)
            {
                var entityType = config.GetInterfaces()
                                       .First(i => i.IsGenericType
                                                   && i.GetGenericTypeDefinition() == typeof(IEntityTypeConfiguration<>))
                                       .GenericTypeArguments
                                       .First();

                var applyConcreteMethod = applyGenericMethod.MakeGenericMethod(entityType);
                var configurationInstance = Activator.CreateInstance(config);
                applyConcreteMethod.Invoke(modelBuilder, [configurationInstance]);
            }
        }

    }
}
