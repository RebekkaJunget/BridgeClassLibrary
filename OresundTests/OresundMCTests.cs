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
    public class OresundMCTests
    {
        [TestMethod()]
        public void OresundMC_WithoutBroBizz_ShouldReturnFullPriceTest()
        {
            // Arrange
            OresundMC mc = new OresundMC("AD12745", new DateTime(2020, 10, 5)); // Weekday, No BroBizz

            // Act

            double actual = mc.Price();

            // Assert
            Assert.AreEqual(235, actual, 0.01);

        }

        [TestMethod()]
        public void OresundMC_WithBroBizz_ShouldReturnDiscountedPriceTest()
        {
            // Arrange
            OresundMC mc = new OresundMC("123ABC", new DateTime(2024, 3, 5), true);

            // Act
            double actual = mc.Price();

            // Assert
            Assert.AreEqual(92, actual, 0.01);
        }

        [TestMethod()]

        public void OresundMC_VehicleType_ShouldReturnCorrectString()
        {
            //Arrange
            OresundMC mc = new OresundMC("123ABC", new DateTime(2020, 3, 5));

            //Act

            string actual = mc.VehicleType();

            //Assert

            Assert.AreEqual("Oresund MC", actual);
        }
    }
}