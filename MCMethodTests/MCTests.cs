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
    public class MCTests
    {
        /// <summary>
        /// unit test for the Price method in the MC class
        /// </summary>
        [TestMethod()]
        public void PriceMethodTest()
        {
            //Arrange
            MC mc = new MC();
            //Act
            double actual = mc.Price();
            //Assert
            Assert.AreEqual(120, actual, "Burde retunere 120.-");
        }

        /// <summary>
        /// unit test for the VehicleType method in the MC class
        /// </summary>'
        [TestMethod()]
        public void VehicleTypeMethodTest()
        {
            //Arrange
            MC mc = new MC();
            //Act
            string actual = mc.VehicleType();
            //Assert
            Assert.AreEqual("MC", actual, "Burde returnere MC");
        }
    }
}