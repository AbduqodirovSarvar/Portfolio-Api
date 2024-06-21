using Domain.Abstractions.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Abstractions
{
    public abstract class BaseEntity : IAudiTable, IDeletable
    {
        [Key]
        public Guid Id { get ; } = Guid.NewGuid();
        public Guid? CreatedById { get ; set ; }
        public DateTime CreatedAt { get ; } = DateTime.UtcNow;
        public bool IsDeleted { get ; set ; } = false;
    }
}
