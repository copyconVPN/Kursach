using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Uchet.Models
{
    public class AccountingPoints
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Code { get; set; }        
        public string PhysicalAddress { get; set; }
        public string Comment { get; set; }
    }
}