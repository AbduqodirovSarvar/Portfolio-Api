﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Models.ViewModels
{
    public class BaseEntityViewModel
    {
        public Guid Id { get; set; }
        public Guid? CreatedById { get; set; }
        public DateTime CreatedAt { get; set; }
    }
}
