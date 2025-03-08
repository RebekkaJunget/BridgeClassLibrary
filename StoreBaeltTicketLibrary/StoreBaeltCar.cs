using BridgeClassLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace StoreBaeltTicketLibrary
{
    public class StoreBaeltCar : Car
    {
        public StoreBaeltCar(string licensePlate, DateTime date, bool broBizz = false) : base(licensePlate, date, broBizz)
        {
        }

        /// <summary>
        /// Overrides the Price methode to apply additional discount on weekends (15%).
        /// BroBizz dicount applies after the weekend discount.
        /// </summary>
        /// <returns>Final price after weeknd dicount</returns>
        public override double Price()
        {
            double price = base.Price();
            //Apply a 15% discount if the vehicle crosses on weekends
            if (Date.DayOfWeek == DayOfWeek.Saturday || Date.DayOfWeek == DayOfWeek.Sunday)
            {
                price *= 0.85; //Weekend dicount 
            }

            //Apply the BroBizz discount after the weekend discount

            if (BroBizz)
            {
                price *= 0.9; //BroBizz discount 10%
            }

            return price;
        }
    }
}
