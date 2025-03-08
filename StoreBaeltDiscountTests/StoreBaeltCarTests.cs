using BridgeClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using StoreBaeltTicketLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreBaeltTicketLibrary.Tests
{
    [TestClass()]
    public class StoreBaeltCarTests
    {
        [TestMethod]
        public void StoreBaeltCar_WithoutBroBizz_Weekday_ShouldReturnFullPriceTest()
        {
            // Arrange
            Car car = new StoreBaeltCar("AD12745", new DateTime(2020, 10, 5)); // Weekday, No BroBizz

            // Act
            double actual = car.Price();

            // Assert
            Assert.AreEqual(230, actual, 0.01); // Expected should be 230, not 240
        }

        [TestMethod()]
        public void StoreBaeltCar_WithBroBizz_Weekday_ShouldReturnDiscountedPriceTest()
        {
            //Arrange
            Car car = new StoreBaeltCar("AB12345", new DateTime(2024, 3, 4), true);
           
            //act
            double actual = car.Price();
            //Assert
            Assert.AreEqual(207, actual, 0.01); // 230 * 0.9 = 207
        }

        [TestMethod]
        public void StoreBaeltCar_WithoutBroBizz_Weekend_ShouldApply15PercentDiscount()
        {
            // Arrange
            Car car = new StoreBaeltCar("CB12645", new DateTime(2024, 3, 2)); // March 2, 2024 (Saturday)

            // Act
            double actual = car.Price();

            // Assert
            Assert.AreEqual(195.5, actual, 0.01); // 230 * 0.85 = 195.5
        }
    }
    
}