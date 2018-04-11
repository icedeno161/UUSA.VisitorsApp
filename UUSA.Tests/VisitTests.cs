using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using UUSA.Biz;

namespace UUSA.Tests
{
    [TestClass]
    public class VisitTests
    {
        /// <summary>
        /// If Null, then the Arrival and Departure Properties of Visit will
        /// return the current DateTime.
        /// </summary>
        [TestMethod]
        public void ArrivalAndDepartureNullTest()
        {
            //Arrange
            var visit = new Visit();
            var expected = DateTime.Today;

            //Act
            var actual_arrival = visit.Arrival.Date;
            var actual_departure = visit.Departure.Date;

            //Assert
            Assert.AreEqual(expected, actual_arrival);
            Assert.AreEqual(expected, actual_departure);
        }

        /// <summary>
        /// Checking to see if by default the value of Host in an instance of Visit
        /// is null.
        /// </summary>
        [TestMethod]
        public void TestHostIsNullByDefault()
        {
            //Arrange
            var visit = new Visit();

            //Act
            var actual = visit.Host;

            //Assert
            Assert.IsNull(actual);
        }

        /// <summary>
        /// This test will confirm that Visitors list is null by default.
        /// </summary>
        [TestMethod]
        public void TestVisitorsListIsNullByDefault()
        {
            //Arrange
            var visit = new Visit();

            //Act
            var actual = visit.Visitors;

            //Assert
            Assert.IsNull(actual);
        }

        /// <summary>
        /// Test will confirm an instance of a Visit object.
        /// </summary>
        [TestMethod]
        public void TestInstanceOfVisit()
        {
            //Arrange
            var visit = new Visit
            {
                Host = new VisitorHost
                {
                    FirstName = "Ivan",
                    LastName = "Cedeno",
                    PhoneNumber = "2129222604"
                },
                Visitors = new List<Visitor>
                {
                    new Visitor
                    {
                        FirstName = "Bernie",
                        LastName = "Cedeno",
                        CompanyName = "Brooklyyn Rep"
                    },
                    new Visitor
                    {
                        FirstName = "Lauren",
                        LastName = "Savage",
                        CompanyName = "14StreetY"
                    }
                },
                Arrival = DateTime.Now.AddDays(1),
                Departure = DateTime.Now.AddDays(1).AddHours(2)
            };
            var expectedHost = "Ivan Cedeno";
            var expectedVisitorName = "Lauren Savage";

            //Act
            var actualHost = visit.Host.FullName;
            var actualVisitor = visit.Visitors.Find
                (v => v.FullName == "Lauren Savage");

            //Assert
            Assert.AreEqual(expectedHost, actualHost);
            Assert.AreEqual(expectedVisitorName, actualVisitor.FullName);
        }

        [TestMethod]
        public void VisitToStringTest()
        {
            //Arrange
            var visit = new Visit
            {
                Host = new VisitorHost
                {
                    FirstName = "Ivan",
                    LastName = "Cedeno",
                    PhoneNumber = "2129222604"
                },
                Visitors = new List<Visitor>
                {
                    new Visitor
                    {
                        FirstName = "Bernie",
                        LastName = "Cedeno",
                        CompanyName = "Brooklyyn Rep"
                    },
                    new Visitor
                    {
                        FirstName = "Lauren",
                        LastName = "Savage",
                        CompanyName = "14StreetY"
                    }
                },
                Arrival = DateTime.Now.AddDays(1),
                Departure = DateTime.Now.AddDays(1).AddHours(2)
            };

            //Act
            Console.WriteLine(visit.ToString());
            //Assert
            Assert.IsNotNull(visit);
        }
    }
}
