using System;
using System.Collections.Generic;

namespace CoffeeShopProducts.Models
{
    public partial class Customer
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public int? FavDrink { get; set; }

        public virtual Coffee? FavDrinkNavigation { get; set; }
    }
}
