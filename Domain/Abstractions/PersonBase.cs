using Domain.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Abstractions
{
    public abstract class PersonBase : BaseEntity
    {
        public string Firstname { get; set; } = null!;
        public string Lastname { get; set;} = null!;
        public string? Middlename { get; set; }
        public Gender Gender { get; set; } = Gender.None;
        public DateOnly Birthday { get; set; }
        [EmailAddress]
        public string Email { get; set; } = null!;
        [Phone]
        public string Phone { get; set; } = null!;
    }
}
