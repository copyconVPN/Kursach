using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Uchet.Models
{
    public class Nomenclature
    {
        [Key]
        public int Id { get; set; }

        [Display(Name = "Наименование")]
        [Required(ErrorMessage = "Наименование не указанно")]
        public string Name { get; set; }

        [Display(Name = "Сорт")]
        public string Sort { get; set; }

        [Display(Name = "Единицы измерения")]
        [Required(ErrorMessage = "Единицы измерения не указаны")]
        public string Unit { get; set; }

        [Display(Name = "Характеристика")]
        public string Property { get; set; }

        [Display(Name = "Комментарий")]
        public string Comment { get; set; }
    }
}