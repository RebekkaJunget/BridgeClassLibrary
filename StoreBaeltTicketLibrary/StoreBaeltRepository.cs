using BridgeClassLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreBaeltTicketLibrary
{
    public class StoreBaeltRepository : IStoreBaeltRepository
    {
        private List<Vehicle> _tickets = new List<Vehicle>();

        /// <summary>
        /// Adds a new ticket(car) to the repository
        /// </summary>
        /// <param name="car">The ticket to be added</param>

        public void AddTicket(Vehicle vehicle)
        {
            _tickets.Add(vehicle);
        }

        /// <summary>
        /// Gets all tickets from the repository
        /// </summary>
        /// <returns>A list of all StoreBaeltCar tickets</returns>

        public List<Vehicle> GetAllTickets()
        {
            return _tickets;
        }
         

        /// <summary>
        /// Gets all tickets from the repository by license plate
        /// </summary>
        /// <param name="licensePlate"></param>
        /// <returns>List of StoreBaeltCar ticket for the specified lincens plate</returns>
        public List<Vehicle> GetTicketByLicensePlate(string licensePlate)
        {
            return _tickets.Where(vehicle => vehicle.Licenseplate == licensePlate).ToList();
        }
    }
}
