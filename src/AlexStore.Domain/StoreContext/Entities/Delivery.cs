using AlexStore.Domain.StoreContext.Enums;
using System;
namespace AlexStore.Domain.StoreContext.Entities
{
    public class Delivery
    {
        public Delivery(DateTime estimatedDeliveryDate)
        {
            EstimatedDeliveryDate = estimatedDeliveryDate;
            CreateDate = DateTime.Now;
            Status = EDeliveryStatus.Waiting;
        }
        public DateTime CreateDate { get; private set; }

        public DateTime EstimatedDeliveryDate { get; private set; }

        public EDeliveryStatus Status { get; private set; }


        public void Ship()
        {
            // Se a Data estimada de entrega for no passado, nao entregar
            Status = EDeliveryStatus.Shipped;
        }

        public void Cancel()
        {
            if(Status != EDeliveryStatus.Delivered)
            {
                Status = EDeliveryStatus.Canceled;
            }
        }

    }
}
