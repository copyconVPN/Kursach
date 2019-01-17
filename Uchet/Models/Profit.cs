using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Uchet.Models
{
    public class Profit
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime Date { get; set; }
        public string Invoice { get; set; }
        public string Provider { get; set; }
        //public string Code { get; set; }
        public string AccountingPoint { get; set; }
        //public string Unit { get; set; }
        public int Quantity { get; set; }
        public float Price { get; set; }
        //public float Cost { get; set; }

    }
}