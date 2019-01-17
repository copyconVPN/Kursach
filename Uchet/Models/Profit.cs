using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Uchet.Models
{
    public class Profit : Product
    {
        [Display(Name = "Поставщик")]
        [Required(ErrorMessage = "Поставщик не выбран")]
        public int ProvidersID { get; set; }
        public Providers Providers { get; set; }

        [Display(Name = "Точка учета")]
        [Required(ErrorMessage = "Точка учета не выбрана")]
        public int AccountingPointsID { get; set; }
        public AccountingPoints AccountingPoints { get; set; }
    }
}