using Domain.Abstractions;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class User : PersonBase
    {
        public Guid PositionId { get; set; }
        public Position? Position { get; set; }
        public string? AboutMe { get; set; }
        public string? PhotoName { get; set; }
        public string? ResumeName { get; set; }
    }
}
