using Microsoft.VisualStudio.TestTools.UnitTesting;
using BridgeClassLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeClassLibrary.Tests
{
    [TestClass()]
    public class VehicleTests
    {
        [TestMethod()]
        public void LicensePlate_ShouldThrowExeption_WhenLongerThan7CharactersTest()
        {
            //Arrange
            string invalidLicensePlate = "1234abce"; //8 characters
            //Act &  Assert
            var ex = Assert.ThrowsException<ArgumentException>(() => new Car(invalidLicensePlate, DateTime.Now));

            //check if the exception message is correct
            Console.WriteLine("Exeption Message: " + ex.Message);
            Assert.AreEqual("Licenseplate can not be more than 7 characters long", ex.Message);
        }


    }
}