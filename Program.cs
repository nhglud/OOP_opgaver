namespace Cars
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Vehicle car1 = new Vehicle("WLHUNG", 50.4);
            Vehicle car2 = new Vehicle("PSYWGN", 24.8);
            CarFerry boaty = new CarFerry("Boaty", 0, 100);
            boaty.AddVehicle(car1);
            boaty.AddVehicle(car2);

            Console.WriteLine(car1.toString());
            Console.WriteLine(boaty.GetVehicle("WLHUNG").getLicencePlate());

            Console.WriteLine(boaty.getTotalWeight()); 
            Console.WriteLine(boaty.isOverWeight());
            Console.WriteLine(boaty.getMaxWeight());
        }
    }
}
