using Domain.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class UserEducation : BaseEntity
    {
        public Guid UserId { get; set; }
       // public User? User { get; set; }
        public Guid EducationId { get; set; }
        public Education? Education { get; set; }
        public DateOnly From { get; set; }
        public DateOnly To { get; set; }
    }
}
