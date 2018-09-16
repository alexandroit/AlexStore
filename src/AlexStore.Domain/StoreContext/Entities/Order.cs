using AlexStore.Domain.StoreContext.Enums;
using FluentValidator;
using System;
using System.Collections.Generic;
using System.Linq;

namespace AlexStore.Domain.StoreContext.Entities
{
    public class Order : Notifiable
    {
        public Order(Customer customer)
        {
            Customer = customer;
            CreateDate = DateTime.Now;
            Status = EOrderStatus.Created;
            Items = new List<OrderItem>();
            Deliveries = new List<Delivery>();
        }

        public Customer Customer { get; private set; }

        public string Number { get; private set; }

        public DateTime CreateDate { get; private set; }

        public EOrderStatus Status { get; private set; }

        public IList<OrderItem> Items { get; private set; }

        public IList<Delivery> Deliveries { get; private set; }

        public void AddItem(Product product, decimal quantity)
        {
            if (quantity > product.QuantityOnHand)
                AddNotification("OrderItem", $"Product {product.Title} não tem {quantity} itens em estoque.");

            var item = new OrderItem(product, quantity);
            Items.Add(item);
        }

        //Create order
        public void Place()
        {
            //Generate Number Order
            Number = Guid.NewGuid().ToString().Replace("-", "").Substring(0, 8).ToUpper();
            if(!Items.Any())
                AddNotification("Order", "Estes pedidos nao tem itens");
        }

        //Pay Order
        public void Pay()
        {
            Status = EOrderStatus.Paid;
        }

        //shipp an order
        public void Ship()
        {
            // A cada 5 produtos � uma entrega
            var deliveries = new List<Delivery>();
            // deliveries.Add(new Delivery(DateTime.Now.AddDays(5)));
            var count = 1;

            // Quebra as entregas
            foreach (var item in Items)
            {
                if (count == 5)
                {
                    count = 1;
                    deliveries.Add(new Delivery(DateTime.Now.AddDays(5)));
                }
                count++;
            }

            // Envia todos as entregas
            deliveries.ForEach(x => x.Ship());

            // Adiciona as entregas ao pedido
            deliveries.ForEach(x => Deliveries.Add(x));
        }

        //Cancel
        public void Cancel()
        {
            Status = EOrderStatus.Canceled;
            Deliveries.ToList().ForEach(x => x.Cancel());
        }
    }
}
