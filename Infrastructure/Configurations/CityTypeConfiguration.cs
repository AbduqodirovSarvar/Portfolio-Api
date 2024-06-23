using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Configurations
{
    public class CityTypeConfiguration : LocalizableEntityTypeConfiguration<City>
    {
        public override void Configure(EntityTypeBuilder<City> builder)
        {
            base.Configure(builder);
            builder.HasOne(x => x.Country).WithMany(x => x.Cities).HasForeignKey(x => x.CountyId);
            builder.HasMany(x => x.Companies).WithOne(x => x.City).HasForeignKey(x => x.CityId);
            builder.HasMany(x => x.Educations).WithOne(x => x.City).HasForeignKey(x => x.CityId);
            builder.HasData([.. UzbekistanCities.Concat(KazakhstanCities)]);
        }

        
    }
}
