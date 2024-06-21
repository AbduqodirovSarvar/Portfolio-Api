using Domain.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Company : LocalizableWithDescriptionEntity
    {
        public Guid CityId { get; set; }
        public City? City { get; set; }
    }
}