namespace Cars
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Vehicle car1 = new Vehicle("WLHUNG", 50.4);
            Vehicle car2 = new Vehicle("PSYWGN", 55.8);
            Vehicle car3 = new Vehicle("PSYWGN", 55.8);
            CarFerry boaty = new CarFerry("Boaty", 0, 200);
            boaty.AddVehicle(car1);
            boaty.AddVehicle(car2);
            boaty.AddVehicle(car3);

            Console.WriteLine(car1.Equals(car2));
            Console.WriteLine(car1.toString());
            Console.WriteLine(boaty.GetVehicle("WLHUNG").getLicencePlate());

            Console.WriteLine(boaty.getTotalWeight()); 
            Console.WriteLine(boaty.isOverWeight());
            Console.WriteLine(boaty.getMaxWeight());
        }
    }
}
