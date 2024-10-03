using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cars
{
    internal class Vehicle
    {
        string licencePlate;
        double weight;
        public Vehicle(string LicencePlate, double Weight)
        {
            licencePlate = LicencePlate;
            weight = Weight;
        }

        public string getLicencePlate()
        { 
            return licencePlate; 
        }

        public double getWeight()
        {
            return weight;
        }

        public string toString()
        {
            return "Licence Plate: " + this.licencePlate + " | Weight : " + this.weight.ToString();
        }
        public bool Equals(Vehicle Other)
        {     
            return licencePlate == Other.getLicencePlate() && weight == Other.getWeight();
        }


    }
}
