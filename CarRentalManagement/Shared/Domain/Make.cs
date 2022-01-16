﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
namespace CarRentalManagement.Shared.Domain

{
    public class Make : BaseDomainModel
    {
        [Required]
        public string Name { get; set; }
    }
}
