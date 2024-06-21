﻿using Domain.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Education : LocalizableWithDescriptionEntity
    {
        public Guid CountryId { get; set; }
        public Country? Country { get; set; }
    }
}
