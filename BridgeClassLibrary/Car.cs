using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeClassLibrary
{


    /// <summary>
    /// Class Car that inherits from the Vehicle class
    /// </summary>
    public class Car : Vehicle
    {
        /// <summary>
        /// Car constructor that takes two parameters licenseplate and date from the base class Vehicle
        /// </summary>
        /// <param name="licenseplate"></param>
        /// <param name="date"></param>
        public Car (string licenseplate, DateTime date, bool broBizz = false) : base(licenseplate, date, broBizz)
        {
        }
        public Car()
        {
        }
        /// <summary>
        /// A override method that returns the price of for crossing the bridge
        /// </summary>
        /// <returns></returns>
        public override double Price()
        {
            return 230;
        }

        /// <summary>
        /// a override method that returns the type of vehicle
        /// </summary>
        /// <returns></returns>
        public override string VehicleType()
        {
            return "Car";
        }
    }
}
