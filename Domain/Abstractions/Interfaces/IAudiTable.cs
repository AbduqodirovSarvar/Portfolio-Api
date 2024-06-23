using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Abstractions.Interfaces
{
    public interface IAudiTable
    {
        Guid? CreatedById { get; set; }
        DateTime CreatedAt { get; set; }
    }
}
