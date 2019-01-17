using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Uchet.Models
{
    public class Product
    {
        [Key]
        public int Id { get; set; }

        [Display(Name = "Наименование")]
        [Required(ErrorMessage = "Наименование не выбрано")]
        public int Name { get; set; }
        public Nomenclature Nomenclature { get; set; }

        [Display(Name = "Дата")]
        [DataType(DataType.Date)]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:yyyy-MM-dd}", NullDisplayText = "")]
        [Required(ErrorMessage = "Введите дату")]
        public DateTime Date { get; set; }

        [Display(Name = "№ накладной")]
        [Required(ErrorMessage = "Введите № накладной")]
        public string Invoice { get; set; }

        [Display(Name = "Колличество")]
        [Required(ErrorMessage = "Введите колличество товара")]
        public int Quantity { get; set; } = 0;

        [Display(Name = "Цена")]
        [Required(ErrorMessage = "Введите цену товара")]
        public int Price { get; set; } = 0;

        [Display(Name = "Стоимость")]
        public int Cost { get; set; } = 0;
    }
}