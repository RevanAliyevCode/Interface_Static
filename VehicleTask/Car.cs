using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleTask
{
    public class Car : IVehicle
    {
        public string Name { get; set; }
        public string PassengerCapacity { get; set; }
        public int MaxSpeed { get; set; }

        public Car(string name, string passengerCapacity, int maxSpeed)
        {
            Name = name;
            PassengerCapacity = passengerCapacity;
            MaxSpeed = maxSpeed;
        }

        public void GetDetails()
        {
            Console.WriteLine($"Name: {Name}, Passenger Capacity: {PassengerCapacity}, Max speed: {MaxSpeed}");
        }

        public void Start()
        {
            Console.WriteLine("Car Start");
        }

        public void Stop()
        {
            Console.WriteLine("Car Stop");
        }
    }
}
