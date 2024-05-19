using Factory.Example.Interfaces;

namespace Factory.Example
{
    /// <summary>
    /// Product interface: The IVehicle interface defines the contract for the products (vehicles) that the factory will create.
    /// Concrete products: The Car and Truck classes implement the IVehicle interface and represent the concrete products.
    /// Factory class: The VehicleFactory class is a static class that contains the CreateVehicle method, which acts as the 
    ///     factory method. It takes a string parameter representing the vehicle type and returns an instance of the corresponding concrete product (Car or Truck).
    /// Exception handling: If an invalid vehicle type is provided, the factory method throws an ArgumentException to 
    ///     handle the error case.
    /// Separation of concerns: The client code (in the Main method) is decoupled from the concrete product classes. 
    ///     It only interacts with the factory and the IVehicle interface, promoting loose coupling and flexibility.
    /// </summary>
    internal class Program
    {
        static void Main(string[] args)
        {
            IVehicle car = VehicleFactory.CreateVehicle("Car");
            car.Drive(); // Output: Driving a car.

            IVehicle truck = VehicleFactory.CreateVehicle("Truck");
            truck.Drive(); // Output: Driving a truck.
        }
    }
}
