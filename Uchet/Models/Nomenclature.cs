using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Uchet.Models
{
    public class Nomenclature
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Sort { get; set; }
        public string Unit { get; set; }
        public string Property { get; set; }
        public string Comment { get; set; }
    }
}