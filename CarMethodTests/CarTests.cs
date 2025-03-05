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
    public class CarTests
    {
        [TestMethod()]

        /// <summary>
        /// Unit test for the Price method in the Car class
        /// <summary>
        public void PriceMethodTest()
        {
            
            //Arrange
            Car car = new Car();
            //Act
            double actual = car.Price();

            //Assert
            Assert.AreEqual(230, actual, "Burde retunere 230.-");

        }

        [TestMethod()]
        ///<summary>    
        ///Unit test for the VehicleType method in the Car class
        ///<!--<summary>-->
        
        public void VihecleTypeMethodTest()
        {
            //Arrange
            Car car = new Car();
            //Act
            string actual = car.VehicleType();
            //Assert
            Assert.AreEqual("Car", actual, "Burde returnere Car");

        }
    }
}