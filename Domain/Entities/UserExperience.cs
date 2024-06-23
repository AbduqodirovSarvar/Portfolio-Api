using Domain.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class UserExperience : BaseEntity
    {
        public Guid UserId { get; set; }
      //  public User? User { get; set; }
        public Guid CompanyId { get; set; }
        public Company? Company { get; set; }
        public Guid PositionId { get; set; }
        public Position? Position { get; set; }
        public Guid WorkTypeId { get; set; }
        public WorkType? WorkType { get; set; }
        public DateOnly? From {  get; set; }
        public DateOnly? To { get; set; }
    }
}
