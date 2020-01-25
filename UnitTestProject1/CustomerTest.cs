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


            string expected = "Arthur, King";

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
        }
    }
