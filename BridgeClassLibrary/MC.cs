using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeClassLibrary
{
    /// <summary>
    /// Class MC with properties Licenseplate and date
    /// </summary>
    public class MC
    {
        public string Licenseplate { get; set; }

        public DateTime date { get; set; }

        /// <summary>
        /// constructor that takes two parameters licenseplate and date
        /// </summary>
        /// <param name="licenseplate"></param>
        /// <param name="date"></param>
        public MC(string licenseplate, DateTime date)
        {
            Licenseplate = licenseplate;
            this.date = date;
        }

        /// <summary>
        /// default constructor
        /// </summary>
        public MC()
        {
        }

        /// <summary>
        /// method that returns the price of for crossing the bridge
        /// </summary>
        /// <returns></returns>
        public double Price()
        {
            return 120;
        }
        /// <summary>
        /// method that returns the type of vehicle
        /// </summary>
        /// <returns></returns>
        public string VehicleType()
        {
            return "MC";
        }
    }
}
