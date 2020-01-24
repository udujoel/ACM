namespace ACM.BL {
    public class Customer {
        private string _lastName;
        private string _firstName;
        private string _email;

        public string LastName {
            get { return _lastName; }
            set { _lastName = value; }
            }

        public string FirstName {
            get { return _firstName; }
            set { _firstName = value; }
            }

        public string Email {
            get { return _email; }
            set { _email = value; }
            }

        public string Phone { get; set; }
        public int any { get; private set; }



        }
    }
