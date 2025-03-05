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
        public string _licenseplate;

        /// <summary>
        /// Property Licenseplate that has a private set and a protected get so that it can be accessed in the derived classes
        /// </summary>
        public string Licenseplate
        {
            get => _licenseplate; 
            protected set
            {
                /// <summary>
                /// if the licenseplate is more than 7 characters long it will throw an exception
                /// </summary>
                if (value.Length > 7)
                {
                    throw new ArgumentException("Licenseplate can not be more than 7 characters long");
                }
                _licenseplate = value;
            }
        }


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
