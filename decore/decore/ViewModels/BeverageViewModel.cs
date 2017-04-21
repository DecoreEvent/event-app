using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using decore.Models;

namespace decore.ViewModels
{
    public class BeverageViewModel
    {
        public ICollection<Beverage> Beverages { get; set; }
        public Beverage Beverage { get; set; }
        public ICollection<Measure> Measures { get; set; }
    }
}