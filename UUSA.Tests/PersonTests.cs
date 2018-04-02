using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using UUSA.Biz;

namespace UUSA.Tests
{
    [TestClass]
    public class PersonTests
    {
        [TestMethod]
        public void PersonTest()
        {
            //Arrange
            var person = new Person
            {
                FirstName = "Ivan",
                LastName = "Cedeno"
            };
            var expected = "Ivan Cedeno";

            //Act
            var actual = person.FullName;

            //Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
