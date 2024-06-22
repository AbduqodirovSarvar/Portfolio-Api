﻿using Domain.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class City : LocalizableEntity
    {
        public Guid CountyId { get; set; }
        public Country? Country { get; set; }
        public ICollection<Company> Companies { get; set; } = [];
        public ICollection<Education> Educations { get; set; } = [];
    }
}
