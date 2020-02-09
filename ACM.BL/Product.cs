using System.Collections.Generic;

namespace ACM.BL
{
    class Product
    {
        public Product()
        {

        }

        public Product(int productId)
        {
            this.productId = productId;
        }
        public int productId { get; private set; }
        public string ProductName { get; set; }
        public string description { get; set; }
        public float currentPrice { get; set; }


        public bool Validate()
        {
            return true;
        }

        public Product Retrieve(int id)
        {
            return new Product();
        }

        public List<Product> Retrieve()
        {
            return new List<Product>();
        }

        public bool Save()
        {
            //save logic
            return true;
        }


    }
}
