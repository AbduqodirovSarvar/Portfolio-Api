using Domain.Abstractions.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Abstractions
{
    public abstract class LocalizableEntity : BaseEntity, ILocalizable
    {
        public string Name { get; set; } = null!;
        public string? NameUz { get ; set ; }
        public string? NameEn { get ; set; }
        public string? NameRu { get ; set ; }
    }
}
