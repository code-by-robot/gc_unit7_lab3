using System;
using System.Collections.Generic;

namespace CoffeeShopProducts.Models
{
    public partial class Coffee
    {
        public Coffee()
        {
            Customers = new HashSet<Customer>();
        }

        public int Id { get; set; }
        public string? Name { get; set; }
        public double? Price { get; set; }
        public bool? Flavored { get; set; }

        public virtual ICollection<Customer> Customers { get; set; }
    }
}
