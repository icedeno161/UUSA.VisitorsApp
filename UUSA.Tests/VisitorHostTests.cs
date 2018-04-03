using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using UUSA.Biz;

namespace UUSA.Biz.Tests
{
    [TestClass()]
    public class VisitorHostTests
    {
        [TestMethod()]
        public void DisplayPhoneNumberTest()
        {
            //Arrange
            var visitorHost = new VisitorHost
            {
                FirstName = "Ivan",
                LastName = "Cedeno",
                PhoneNumber = "2128675309"
            };
            var expected = "(212) 867-5309";

            //Act
            var actual = visitorHost.DisplayPhoneNumber();

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void PhoneNumberLengthTest()
        {
            //Arrange
            var visitorHost = new VisitorHost
            {
                FirstName = "Ivan",
                LastName = "Cedeno",
                PhoneNumber = "212867530097826" // not of length 10
            };

        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void PhoneNumberNumericTest()
        {
            //Arrange
            var visitorHost = new VisitorHost
            {
                FirstName = "Ivan",
                LastName = "Cedeno",
                PhoneNumber = "212867530m" // not numeric
            };

        }
    }
}

namespace UUSA.Tests
{
    [TestClass]
    public class VisitorHostTests
    {
        [TestMethod]
        public void VisitorHostTest()
        {
            //Arrange
            var visitorHost = new VisitorHost
            {
                FirstName = "Ivan",
                LastName = "Cedeno",
                PhoneNumber = "2128675309"
            };
            var expected = "2128675309";

            //Act
            var actual = visitorHost.PhoneNumber;

            //Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
