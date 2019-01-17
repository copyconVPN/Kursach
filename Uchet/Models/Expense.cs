using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Uchet.Models
{
    public class Expense
    {
        public int Id { get; set; }
        [Display(Name = "Наименование")]
        [Required(ErrorMessage = "Наименование не указано")]
        public string Name { get; set; }

        [Display(Name = "Дата прихода")]
        [Required(ErrorMessage = "Дата не указана")]
        public DateTime Date { get; set; }

        [Display(Name = "Накладная")]
        [Required(ErrorMessage = "Наименование не указано")]
        public string Invoice { get; set; }

        [Display(Name = "Поставщик")]
        [Required(ErrorMessage = "Поставщик не указан")]
        public string Provider { get; set; }

        [Display(Name = "Точка учета")]
        [Required(ErrorMessage = "Точка учета не указана")]
        public string ShippingAccountingPoint { get; set; }

        [Display(Name = "Точка учета")]
        [Required(ErrorMessage = "Точка учета не указана")]
        public string DeliveryAccountingPoint { get; set; }

        [Display(Name = "Покупатель")]
        [Required(ErrorMessage = "Покупатель не указан")]
        public string Byer { get; set; }


        public string Unit { get; set; }

        [Display(Name = "Количество")]
        [Required(ErrorMessage = "Количество не указано")]
        public int Quantity { get; set; }

        [Display(Name = "Цена")]
        [Required(ErrorMessage = "Цена не указана")]
        public float Price { get; set; }

        public float Cost { get; set; }
    }
}