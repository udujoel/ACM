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
        public string ProductDescription { get; set; }
        public decimal? currentPrice { get; set; }


        public bool Validate()
        {
            bool isValid = true;

            if (string.IsNullOrWhiteSpace(ProductName))
            {
                isValid = false;
            }

            if (decimal.Equals(currentPrice, null))
            {
                isValid = false;
            }


            return isValid;
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
