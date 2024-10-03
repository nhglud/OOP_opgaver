using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cars
{
    internal class CarFerry
    {
        
        string name;
        double weight;
        double maxWeight;
        List<Vehicle> vehicles;

        public CarFerry(string name, double weight, double maxWeight)
        {
            this.name = name;
            this.weight = weight;
            this.maxWeight = maxWeight;
            this.vehicles = new List<Vehicle>();
        }

        public void AddVehicle(Vehicle vehicle)
        {
            foreach (Vehicle v in this.vehicles)
            {
                if (vehicle.Equals(v))
                {
                    Console.WriteLine("A car with: " + vehicle.toString() + " has already been loaded.");
                    return;
                }
            }

            if ( this.weight + vehicle.getWeight() > this.maxWeight)
            {
                Console.WriteLine("WARNING: Car ferry " + this.name + " cannot carry more cars.");
                return;
            }

            if (this.weight + vehicle.getWeight() > this.maxWeight * 0.9 && this.weight + vehicle.getWeight() != this.maxWeight)
            {
                Console.WriteLine("WARNING: Car ferry " + this.name + " is nearly full.");
            }

            if (this.weight + vehicle.getWeight() == this.maxWeight)
            {
                Console.WriteLine("WARNING: Car ferry " + this.name + " is at max capacity.");
            }            

            this.vehicles.Add(vehicle);
            this.weight += vehicle.getWeight();
        }

        public void RemoveVehicle(Vehicle vehicle)
        {
            this.vehicles.Remove(vehicle);
            this.weight -= vehicle.getWeight();
        }

        public Vehicle GetVehicle(string LicencePlate)
        {
            foreach (Vehicle vehicle in this.vehicles)
            {
                if (vehicle.getLicencePlate() == LicencePlate)
                {
                    return vehicle;
                }
            }

            return null;
        }

        public double getTotalWeight() 
        { 
            return this.weight; 
        }

        public bool isOverWeight()
        {
            return (this.weight > this.maxWeight);
        }

        public string getName()
        {
            return this.name;
        }

        public void setName(string NewName)
        { 
            this.name = NewName; 
        }
        
        public double getWeight()
        {
            return this.weight;
        }

        public double getMaxWeight()
        { 
            return this.maxWeight; 
        }

    }
}
