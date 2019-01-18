using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Uchet.Models
{
    public class Product
    {
        public int Id { get; set; }
        [Display(Name = "Наименование")]
        [Required(ErrorMessage = "Наименование не указано")]
        public int Nomenclature { get; set; }

        [Display(Name = "Дата")]
        [DataType(DataType.Date)]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:yyyy-MM-dd}", NullDisplayText = "")]
        [Required(ErrorMessage = "Дата не указана")]
        public DateTime Date { get; set; }

        [Display(Name = "Накладная")]
        [Required(ErrorMessage = "Наименование не указано")]
        public string Invoice { get; set; }

        [Display(Name = "Количество")]
        [Required(ErrorMessage = "Количество не указано")]
        public int Quantity { get; set; }

        [Display(Name = "Цена")]
        [Required(ErrorMessage = "Цена не указана")]
        public float Price { get; set; }
    }
}