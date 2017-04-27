using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace decore.Models
{
    public class Beverage
    {
        public int BeverageId { get; set; }
        public string Title { get; set; }
        public double Volume { get; set; }
        public double Price { get; set; }

        
    }
}