using System;

namespace ACM.BL {
    public class testing {
        public static void Main(String[] args) {

            Customer myTestCustomer = new Customer();
            Console.WriteLine("Firstname: ");
            myTestCustomer.FirstName = Console.ReadLine();
            Console.WriteLine("Lastname: ");
            myTestCustomer.LastName = Console.ReadLine();
            //
            Console.WriteLine($@"Firstname was: {myTestCustomer.FirstName}
Lastname was: {myTestCustomer.LastName}");

            Console.ReadKey();
            }



        }
    }