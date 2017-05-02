using System.Collections.Generic;
using Decore.Models;

namespace decore.ViewModels
{
    public class BeverageViewModel
    {
        public ICollection<Beverage> Beverages { get; set; }
        public Beverage Beverage { get; set; }
        public ICollection<Measure> Measures { get; set; }
    }
}