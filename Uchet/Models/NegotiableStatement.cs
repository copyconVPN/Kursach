using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Uchet.Models
{
    public class NegotiableStatement
    {
        public string Name { get; set; }
        public string Sort { get; set; }
        public string Unit { get; set; }
        public string Property { get; set; }
        public int Arrival { get; set; } = 0;
        public int Shipment { get; set; } = 0;
        public int Remainder { get; set; } = 0;
    }
}