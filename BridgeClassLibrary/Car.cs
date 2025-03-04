using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeClassLibrary
{


    /// <summary>
    /// Class Car with properties Licenseplate and date 
    /// </summary>
    public class Car
    {
        /// <summary>
        /// properties Licenseplate 
        /// </summary>
        public string Licenseplate { get; set; }

        /// <summary>
        /// properties date 
        /// </summary>

        public DateTime date { get; set; }

        /// <summary>
        /// A constructor that takes two parameters licenseplate and date
        /// </summary>
        /// <param name="licenseplate"></param>
        /// <param name="date"></param>
        public Car(string licenseplate, DateTime date)
        {
            Licenseplate = licenseplate;
            this.date = date;
        }

        /// <summary>
        /// a default constructor
        /// </summary>
        public Car()
        {
        }

        /// <summary>
        /// A method that returns the price of for crossing the bridge
        /// </summary>
        /// <returns></returns>
        public double Price()
        {
            return 230;
        }

        /// <summary>
        /// a method that returns the type of vehicle
        /// </summary>
        /// <returns></returns>
        public string VehicleType()
        {
            return "Car";
        }
    }
}
