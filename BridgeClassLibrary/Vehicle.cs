using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeClassLibrary
{
    /// <summary>
    /// Abstract class Vehicle with properties Licenseplate and date. Also a base class for vehicles
    /// </summary>
    public abstract class Vehicle
    {
        /// <summary>
        /// protcted set because we want to be able to set the licenseplate in the constructor
        /// </summary>
        public string Licenseplate { get; protected set; }
        public DateTime date { get; protected set; }

        /// <summary>
        /// A constructor that takes two parameters licenseplate and date
        /// </summary>
        /// <param name="licenseplate"></param>
        /// <param name="date"></param>
        protected Vehicle(string licenseplate, DateTime date)
        {
            Licenseplate = licenseplate;
            this.date = date;
        }

        protected Vehicle()
        {
        }

        /// <summary>
        /// Abstract method that returns the price of for crossing the bridge
        /// </summary>
        /// <returns></returns>
        public abstract double Price();

        /// <summary>
        /// Abstract method that returns the type of vehicle
        /// </summary>
        /// <returns></returns>
        public abstract string VehicleType();

    }
}
