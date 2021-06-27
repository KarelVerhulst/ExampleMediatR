using System;
namespace ExampleMediatR.Dtos
{
    public class Order
    {
        public int ID { get; set; }
        public DateTime DeliveryDate { get; set; }
        public bool Delivered { get; set; }

        public Order()
        {
        }
    }
}
