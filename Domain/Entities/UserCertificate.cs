using Domain.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class UserCertificate : LocalizableWithDescriptionEntity
    {
        public Guid UserId { get; set; }
        public User? User { get; set; }
        public string? CertificateUrl { get; set; }
        public string? Credential { get; set; }
        public DateOnly Issued { get; set; }
        public string? CertificateFileName { get; set; }
    }
}
