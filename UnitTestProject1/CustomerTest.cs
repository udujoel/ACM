using ACM.BL;

using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject1 {
    [TestClass]
    public class CustomerTest {
        [TestMethod]
        public void FullNameTestValid() {
            //arrange

            Customer myCustomer = new Customer {
                FirstName = "Arthur" ,
                LastName = "King" ,
                Email = "kingArthur@rmail.com"
                };


            string expected = "King, Arthur";

            //act
            string actual = myCustomer.FullName;
            //assert

            Assert.AreEqual(expected , actual);


            }

        [TestMethod]
        public void FullNameFirstNameEmpty() {
            //arrange
            Customer myCustomer = new Customer() {
                FirstName = "James"
                };
            string expected = "James";

            //act
            string actual = myCustomer.FullName;
            //assert

            Assert.AreEqual(actual , expected);
            }


        [TestMethod]
        public void FullNameLastNameEmpty() {
            //arrange
            Customer myCustomer = new Customer() {
                LastName = "Bond"
                };
            string expected = "Bond";

            //act
            string actual = myCustomer.FullName;
            //assert

            Assert.AreEqual(actual , expected);
            }

        [TestMethod]
        public void CustomerStaticTest() {
            //arrange 
            Customer customer1 = new Customer() {
                LastName = "Bond"
                };
            Customer.InstanceCount++;

            Customer customer2 = new Customer();
            customer2.LastName = "Tim";
            Customer.InstanceCount++;

            Customer customer3 = new Customer();
            customer3.LastName = "Ceaser";
            Customer.InstanceCount++;
            //act
            int expected = 3;

            //assert

            Assert.AreEqual(Customer.InstanceCount , expected);
            }

        [TestMethod]
        public void CustomerValidateMissingLastName() {
            //arrange
            Customer myCustomer = new Customer { Email = "BondJames@gmail.com" };
            bool expected = false;

            //act

            bool actual = myCustomer.Validate();

            //assert

            Assert.AreEqual(expected , actual);
            }
        [TestMethod]
        public void CustomerValidateValid() {
            //arrange
            Customer myCustomer = new Customer {
                Email = "BondJames@gmail.com" ,
                LastName = "Tony"
                };
            bool expected = true;

            //act

            bool actual = myCustomer.Validate();

            //assert

            Assert.AreEqual(expected , actual);
            }
        }
    }
