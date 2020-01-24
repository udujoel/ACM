using ACM.BL;

using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject1 {
    [TestClass]
    public class UnitTest1 {
        [TestMethod]
        public void FullNameTestValid() {
            //arrange

            Customer myCustomer = new Customer();

            myCustomer.LastName = "King";
            myCustomer.FirstName = "Arthur";
            myCustomer.Email = "kingArthur@rmail.com";

            string expected = "Arthur, King";

            //act
            string actual = myCustomer.FullName;
            //assert

            Assert.AreEqual(expected , actual);


            }
        }
    }
