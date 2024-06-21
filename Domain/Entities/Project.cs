using Domain.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Project : LocalizableWithDescriptionEntity
    {
        public Guid UserId { get; set; }
        public User? User { get; set; }
        public string UrlSrc { get; set; } = null!;
        public string? Url { get; set; }
        public string? PhotoName { get; set; }
    }
}
