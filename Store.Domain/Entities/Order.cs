using System;

namespace Store.Domain.Entities
{
    public class Order : Entity
    {
        public Order(Customer customer, decimal deliveryFee, Discount discount)
        {
            Customer = customer;
            Date = DateTime.Now;

        }
        public Customer Customer { get; private set; }
        public DateTime Date { get; private set; }
    }
}