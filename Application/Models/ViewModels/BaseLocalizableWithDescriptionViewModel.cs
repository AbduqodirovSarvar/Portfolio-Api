using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Models.ViewModels
{
    public class BaseLocalizableWithDescriptionViewModel : BaseLocalizableEntityViewModel
    {
        public string? Description { get; set; }
        public string? DescriptionUz { get; set; }
        public string? DescriptionEn { get; set; }
        public string? DescriptionRu { get; set; }
    }
}
