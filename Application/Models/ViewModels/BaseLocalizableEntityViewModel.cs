using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Models.ViewModels
{
    public class BaseLocalizableEntityViewModel : BaseEntityViewModel
    {
        public string? Name { get; set; }
        public string? NameUz { get; set; }
        public string? NameEn { get; set; }
        public string? NameRu { get; set; }
    }
}
