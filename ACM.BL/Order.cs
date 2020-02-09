using System;
using System.Collections.Generic;

namespace ACM.BL
{
    public class Order
    {
        public Order()
        {

        }

        public Order(int orderId)
        {
            OrderId = orderId;
        }


        public DateTimeOffset? OrderDate { get; set; }
        public int OrderId { get; private set; }


        public bool Validate()
        {
            bool isValid = true;

            if (OrderDate == null)
            {
                isValid = false;
            }

            return isValid;
        }

        public Order Retrieve(int OrderId)
        {
            return new Order();
        }

        public List<Order> Retrieve()
        {
            return new List<Order>();
        }

        public bool Save()
        {
            //save logic
            return true;
        }

    }
}