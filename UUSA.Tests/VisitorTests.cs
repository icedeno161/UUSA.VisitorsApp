using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using UUSA.Biz;

namespace UUSA.Tests
{
    [TestClass]
    public class VisitorTests
    {
        [TestMethod]
        public void VisitorTest()
        {
            //Arrange
            var dateNow = DateTime.Now;
            var dateNowPlus2 = dateNow.AddHours(2);
            var visitor = new Visitor
            {
                FirstName = "Ivan",
                LastName = "Cedeno",
                CompanyName = "UNICEF USA",
            };
            var expectedCompanyName = "UNICEF USA";
            var expectedArrival = dateNow;
            var expectedDeparture = dateNowPlus2;

            //Act

            //Assert
            Assert.AreEqual(expectedCompanyName, visitor.CompanyName);
        }
    }
}
