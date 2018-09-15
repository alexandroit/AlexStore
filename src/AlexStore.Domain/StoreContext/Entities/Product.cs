using System;
using System.Collections.Generic;
using System.Text;

namespace AlexStore.Domain.StoreContext.Entities
{
    public class Product
    {
        public string Title { get; set; }

        public string Description { get; set; }

        public string Image { get; set; }

        public double Price { get; set; }

        public int QuantityOnHand { get; set; }
    }
}
