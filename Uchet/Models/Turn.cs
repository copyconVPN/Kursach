using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Uchet.Models
{
    public class Turn
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Sort { get; set; }
        public string Unit { get; set; }
        public float Profit { get; set; } = 0;
        public float Exspense { get; set; } = 0;
        public float Balance { get; set; } = 0;
    }
}