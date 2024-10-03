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
