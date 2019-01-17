using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Uchet.Models
{
    public class Providers
    {
        [Key]
        public int Id { get; set; }

        [Display(Name = "Наименование")]
        [Required(ErrorMessage = "Наименование не указанно")]
        public string Name { get; set; }

        [Display(Name = "Код")]
        public string Code { get; set; }

        [Display(Name = "Юридический адрес")]
        [Required(ErrorMessage = "Адрес не указан")]
        public string LegalAddress { get; set; }

        [Display(Name = "Почтовый адрес")]
        public string PhysicalAddress { get; set; }

        [Display(Name = "Комментарий")]
        public string Comment { get; set; }
    }
}