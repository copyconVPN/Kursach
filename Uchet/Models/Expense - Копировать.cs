using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Uchet.Models
{
    public class Expense : Product
    {
        [Display(Name = "Точка учета прихода")]
        [Required(ErrorMessage = "Точка учета не указана")]
        public int ShippingAccountingPoint { get; set; }

        [Display(Name = "Точка учета отгрузки")]
        [Required(ErrorMessage = "Точка учета не указана")]
        public int DeliveryAccountingPoint { get; set; }

        [Display(Name = "Покупатель")]
        [Required(ErrorMessage = "Покупатель не указан")]
        public int Buyer { get; set; }
    }

    public class ExpenseList : Expense
    {
        [Display(Name = "Наименование")]
        [Required(ErrorMessage = "Наименование не указано")]
        new public string Nomenclature { get; set; }

        [Display(Name = "Точка учета")]
        [Required(ErrorMessage = "Точка учета не указана")]
        new public string ShippingAccountingPoint { get; set; }

        [Display(Name = "Точка учета")]
        [Required(ErrorMessage = "Точка учета не указана")]
        new public string DeliveryAccountingPoint { get; set; }

        [Display(Name = "Покупатель")]
        [Required(ErrorMessage = "Покупатель не указан")]
        new public string Buyer { get; set; }
    }
}