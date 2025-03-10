using BridgeClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using StoreBaeltTicketLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace StoreBaeltTicketLibrary.Tests
{
    [TestClass()]
    public class StoreBaeltRepositoryTests
    {
        [TestMethod()]
        //Purpose : test that when a ticket is added to the repositry, it is stored correctly
        //Expected Result: The repository should containt 1 ticket with the correct license plate
        public void AddTicket_ShouldStoreTicketTest()
        {
            //Arrange
            StoreBaeltRepository storeBaeltRepository = new StoreBaeltRepository(); //Create a new repository
            Vehicle car = new StoreBaeltCar("1234567", DateTime.Now); //Create a new car with license plate '1234567'

            //Act'

            storeBaeltRepository.AddTicket(car); //Add the car to the repository
            List<Vehicle> tickets = storeBaeltRepository.GetAllTickets(); //Get all tickets from the repository

            //Assert
            Assert.AreEqual(1, tickets.Count); //Check that the repository contains 1 ticket
            Assert.AreEqual("1234567", tickets[0].Licenseplate); //Check that the ticket has the correct license plate
        }

        [TestMethod()]
        //Purpose : test to ensure that the GetTicketByLicensePlate method returns the correct ticket by license plate
        //Expected Result: The method should return the correct ticket with the specified license plate also if there are multiple tickets with the same license plate
        public void GetTicketByLicensePlate_ShouldReturnTicketTest()
        {
            //Arrange
            StoreBaeltRepository storeBaeltRepository = new StoreBaeltRepository();
            Vehicle car1 = new StoreBaeltCar("XCK4321", new DateTime(2024, 3, 6));
            Vehicle car2 = new StoreBaeltCar("ABC4567", new DateTime(2024, 3, 5)); //Same car with different date
            Vehicle car3 = new StoreBaeltCar("ABC4567", new DateTime(2024, 3, 7)); //Same car with different date
            storeBaeltRepository.AddTicket(car1);
            storeBaeltRepository.AddTicket(car2);
            storeBaeltRepository.AddTicket(car3);

            //Act
            List<Vehicle> result = storeBaeltRepository.GetTicketByLicensePlate("XCK4321"); //Get all tickets with license plate 'XCK4321'
            List<Vehicle> result2 = storeBaeltRepository.GetTicketByLicensePlate("ABC4567"); //Get all tickets with license plate 'ABC4567'


            //Assert
            Assert.AreEqual("XCK4321", result[0].Licenseplate);//Check that the tickets have the correct license plate
            Assert.AreEqual(2, result2.Count); //Check that the method returns 2 tickets
            Assert.AreEqual("ABC4567", result2[0].Licenseplate);
            Assert.AreEqual("ABC4567", result2[1].Licenseplate);


        }
        [TestMethod]
        public void Interface_Implementation_Test()
        {
            // Arrange
            IStoreBaeltRepository repository = new StoreBaeltRepository();

            // Act
            repository.AddTicket(new StoreBaeltCar("1234567", System.DateTime.Now));
            List<Vehicle> tickets = repository.GetAllTickets();

            // Assert
            Assert.AreEqual(1, tickets.Count); // Ensure the repository works
        }

    }
}