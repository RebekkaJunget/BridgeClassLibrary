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
    public class BroBizzDiscountTests
    {
        [TestMethod()]
        public void CarPrice_WithBroBizz_ShouldApply10PercentDiscountTest()
        {
            //Arrange
            Car car = new Car("ABC1234", DateTime.Now, true); //BroBizz discount
          
            //Act
            double basePrice = car.Price(); //230
            double expected = basePrice * 0.9; //10% discount
            double actual = car.DiscountPrice();
            //Assert (using delta to allow for a small difference in the double values)
            Assert.AreEqual(expected, actual, 0.01, "The price should be 10% lower");
        }

        [TestMethod()]

        public void MCPrice_WithBroBizz_ShouldApply10PercentDiscountTest()
        {
            //Arrange
            MC mc = new MC("XYZ5678", DateTime.Now, true); //BroBizz discount
            //Act
            double basePrice = mc.Price();
            double expected = basePrice * 0.9; //10% discount
            double actual = mc.DiscountPrice();
            //Assert (using delta to allow for a small difference in the double values)
            Assert.AreEqual(expected, actual, 0.01, "The price should be 10% lower");
        }

        [TestMethod()]

        public void CarPrice_WithoutBroBizz_ShouldNotApplyDiscountTest()
        {
            //Arrange
            Car car = new Car("ABC1234", DateTime.Now); //No BroBizz discount
            //Act
            double actual = car.Price();
            double expected = 230; //No discount
            //Assert (using delta to allow for a small difference in the double values)
            Assert.AreEqual(expected, actual, 0.01, "The price should be the same");
        }
    }

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