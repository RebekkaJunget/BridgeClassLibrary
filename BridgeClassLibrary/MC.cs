using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeClassLibrary
{
    /// <summary>
    /// Class MC inherits from the Vehicle class
    /// </summary>
    public class MC : Vehicle
    {
        /// <summary>
        /// constructor that takes two parameters licenseplate and date from the base class Vehicle
        /// </summary>
        /// <param name="licenseplate"></param>
        /// <param name="date"></param>
        public MC(string licenseplate, DateTime date) : base(licenseplate, date)
        {
        }
        public MC()
        {
        }
       

        /// <summary>
        /// method that returns the price of for crossing the bridge
        /// </summary>
        /// <returns></returns>
        public override double Price()
        {
            return 120;
        }
        /// <summary>
        /// method that returns the type of vehicle
        /// </summary>
        /// <returns></returns>
        public override string VehicleType()
        {
            return "MC";
        }
    }
}
