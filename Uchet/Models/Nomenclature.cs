using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Uchet.Models
{
    public class Nomenclature : Partner
    {
        [Display(Name = "Сорт")]
        public string Sort { get; set; }

        [Display(Name = "Ед.изм.")]
        [Required(ErrorMessage = "Ед.изм. не указанны")]
        public string Unit { get; set; }

        [Display(Name = "Характеристика")]
        public string Property { get; set; }
    }
}