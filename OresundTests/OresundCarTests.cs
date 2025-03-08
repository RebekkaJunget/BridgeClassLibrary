using Microsoft.VisualStudio.TestTools.UnitTesting;
using Oresundbroen;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oresundbroen.Tests
{
    [TestClass()]
    public class OresundCarTests
    {
        [TestMethod()]
        public void OresundCar_WithoutBroBizz_ShouldReturnFullPriceTest()
        {
            // Arrange
            OresundCar car = new OresundCar("AD12745", new DateTime(2020, 10, 5)); // Weekday, No BroBizz
            // Act
            double actual = car.Price();
            // Assert
            Assert.AreEqual(460, actual, 0.01);
        }

        [TestMethod]
        public void OresundCar_WithBroBizz_ShouldReturnDiscountedPrice()
        {
            // Arrange
            OresundCar car = new OresundCar("123ABC", new DateTime(2024, 3, 5), true);

            // Act
            double actual = car.Price();

            // Assert
            Assert.AreEqual(178, actual, 0.01);
        }

        [TestMethod()]

        public void OresundCar_VehicleType_ShouldReturnCorrectString()
        {
            //Arrange
            OresundCar car = new OresundCar("123ABC", new DateTime(2020, 10, 5));

            //Act
            string actual = car.VehicleType();

            //Assert
            Assert.AreEqual("Oresund Car", actual);

        }

        
    }
}