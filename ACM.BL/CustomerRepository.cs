namespace ACM.BL
{
    public class CustomerRepository
    {
        public Customer Retrieve(int customerId)
        {
            Customer customer = new Customer(customerId);


            if (customerId == 1)
            {
                customer.Email = "Clarkkent@krypton.com";
                customer.FirstName = "Super";
                customer.LastName = "Man";
            }
            return customer;
        }

        public bool Save(Customer customer)
        {


            return true;
        }
    }
}
