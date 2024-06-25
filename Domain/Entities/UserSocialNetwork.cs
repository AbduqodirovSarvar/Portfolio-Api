using Domain.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class UserSocialNetwork : BaseEntity
    {
        public Guid UserId { get; set; }
        public Guid SocialNetworkId { get; set; }
        public SocialNetwork? SocialNetwork { get; set; }
        public string Url { get; set; } = null!;
    }
}
