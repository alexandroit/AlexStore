using System;
using System.Collections.Generic;
using System.Text;

namespace AlexStore.Domain.StoreContext.Entities
{
    public class OrderItem
    {
        public Order Order { get; set; }

        public Product Product { get; set; }

        public int Quantity { get; set; }

        public double Price { get; set; }
    }
}
