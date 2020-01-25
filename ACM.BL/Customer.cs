namespace ACM.BL {
    public class Customer {
        public int CustomerId { get; private set; }

        public string LastName { get; set; }

        public string FirstName { get; set; }

        public string Email { get; set; }


        public string FullName {
            get {
                string fullName = FirstName + " " + LastName;
                if (!string.IsNullOrWhiteSpace(fullName)) {

                    if (!string.IsNullOrWhiteSpace(FirstName)) {
                        fullName = LastName;
                        }

                    if (!string.IsNullOrWhiteSpace(LastName)) {
                        fullName = FirstName;
                        }

                    }
                else if (string.IsNullOrWhiteSpace(fullName)) {
                    fullName = "";
                    }


                return fullName;
                }

            }

        }
    }
