namespace ACM.BL
{
    public class Address
    {
        public Address()
        {

        }

        public Address(int addressId)
        {
            AddressId = addressId;
        }


        public int AddressId { get; private set; }
        public string StreetLine1 { get; set; }
        public string StreetLine2 { get; set; }

        public string City { get; set; }
        public string State { get; set; }
        public long PostalCode { get; set; }
        public string Country { get; set; }
        public int AddressType { get; set; }


        public bool Validate()
        {
            bool isValid = true;

            if (string.IsNullOrWhiteSpace(StreetLine1) || string.IsNullOrWhiteSpace(City) ||
                string.IsNullOrWhiteSpace(State) || string.IsNullOrWhiteSpace(Country))
            {
                isValid = false;
            }

            if (PostalCode == 0 || AddressType == 0)
            {
                isValid = false;
            }

            return isValid;
        }
    }
}
