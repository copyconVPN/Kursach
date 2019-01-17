using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Uchet.Models
{
    public class Buyer : Partner
    {
        [Display(Name = "Адрес")]
        public string PhysicalAddress { get; set; }
    }
}