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

        public bool BroBizz { get; protected set; } //New property BroBizz to indicate if the vehicle uses a BroBizz


        public DateTime Date { get; protected set; }

        /// <summary>
        /// A constructor that takes two parameters licenseplate and date
        /// </summary>
        /// <param name="licenseplate">registrering nummer</param>
        /// <param name="date">Dato da man krydsede broen</param>
        protected Vehicle(string licenseplate, DateTime date, bool broBizz = false)
        {
            Licenseplate = licenseplate;
            Date = date;
            BroBizz = broBizz;
        }

        protected Vehicle()
        {
        }

        /// <summary>
        /// Abstract method that returns the price of for crossing the bridge
        /// </summary>
        /// <returns>Retuner standard pris</returns>
        public abstract double Price(); //Price without discount

        /// <summary>
        /// New method DiscountPrice that returns the price with 10% discount if BroBizz is true.
        /// </summary>
        /// <returns>Retuner prisen med brobizz rabat</returns>
        public double DiscountPrice()
        {
            double price = Price();
            return BroBizz ? price * 0.9 : price; //If BroBizz is true, the price will be 10% less
        }

        /// <summary>
        /// Abstract method that returns the type of vehicle
        /// </summary>
        /// <returns>Retuner køretøj type</returns>
        public abstract string VehicleType();


       
    }
}
