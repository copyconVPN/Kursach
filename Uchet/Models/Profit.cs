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
        [Required(ErrorMessage = "Поставщик не указан")]
        public int Provider { get; set; }

        [Display(Name = "Точка учета")]
        [Required(ErrorMessage = "Точка учета не указана")]
        public int AccountingPoint { get; set; }
    }

    public class ProfitList : Profit
    {
        [Display(Name = "Наименование")]
        [Required(ErrorMessage = "Наименование не указано")]
        new public string Nomenclature { get; set; }

        [Display(Name = "Поставщик")]
        [Required(ErrorMessage = "Поставщик не указан")]
        new public string Provider { get; set; }

        [Display(Name = "Точка учета")]
        [Required(ErrorMessage = "Точка учета не указана")]
        new public string AccountingPoint { get; set; }
    }
}