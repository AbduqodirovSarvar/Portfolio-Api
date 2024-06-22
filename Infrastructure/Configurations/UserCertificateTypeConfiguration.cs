using Domain.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Configurations
{
    public class UserCertificateTypeConfiguration : LocalizableWithDescriptionEntityTypeConfiguration<UserCertificate>
    {
        public override void Configure(EntityTypeBuilder<UserCertificate> builder)
        {
            base.Configure(builder);
        }
    }
}
