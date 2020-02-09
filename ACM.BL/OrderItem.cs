using System.Collections.Generic;

namespace ACM.BL
{
    class OrderItem
    {
        public OrderItem()
        {

        }
        public OrderItem(int orderItemId)
        {
            OrderItemId = orderItemId;
        }



        public int OrderItemId { get; private set; }
        public int ProductId { get; set; }

        public int Quantity { get; set; }

        public decimal? PurchasePrice { get; set; }


        public bool Validate()
        {
            bool isValid = true;

            if (PurchasePrice == null)
            {
                isValid = false;
            }

            if (Quantity <= 0)
            {
                isValid = false;
            }

            if (ProductId <= 0)
            {
                isValid = false;
            }
            return isValid;
        }

        public OrderItem Retrieve(int id)
        {
            return new OrderItem();
        }

        public List<OrderItem> Retrieve()
        {
            return new List<OrderItem>();
        }

        public bool Save()
        {
            //save logic
            return true;
        }

    }
}
