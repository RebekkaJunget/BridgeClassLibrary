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
        /// <param name="licenseplate">registrerings nummer</param>
        /// <param name="date">Dato for krydsning af broen</param>
        /// <param name="broBizz">Hvis der er en brobizz</param>
        public MC(string licenseplate, DateTime date, bool broBizz = false) : base(licenseplate, date, broBizz)
        {
        }
        public MC()
        {
        }
       

        /// <summary>
        /// method that returns the price of for crossing the bridge
        /// </summary>
        /// <returns>Retuner standard prisen for MC</returns>
        public override double Price()
        {
            return 120;
        }
        /// <summary>
        /// method that returns the type of vehicle
        /// </summary>
        /// <returns>Retuner køretøjs typen MC</returns>
        public override string VehicleType()
        {
            return "MC";
        }
    }
}
