using Classes;
using System.Text;

namespace Sana05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.InputEncoding = Encoding.UTF8;

            List<Vehicle> vehicles = new List<Vehicle>();

            vehicles.Add(new Car("Toyota", "Camry", 2022, 850000, 4, FuelType.Бензин));
            vehicles.Add(new Truck("MAN", "TGX", 2021, 2500000, 20, 3));
            vehicles.Add(new Motorcycle("Honda", "CBR 1000RR", 2020, 500000, 1000, true));
            vehicles.Add(new Car("Volkswagen", "Golf 8", 2023, 1200000, 5, FuelType.Електро));
            vehicles.Add(new Motorcycle("BMW", "R 1250 GS", 2023, 850000, 1254, true));

            Console.WriteLine("=== Інформація про транспортні засоби ===\n");

            double totalTax = 0;

            Vehicle fastestVehicle = vehicles[0];

            foreach (var vehicle in vehicles)
            {
                vehicle.DisplayInfo();

                totalTax += vehicle.CalculateTax();

                if (vehicle.GetMaxSpeed() > fastestVehicle.GetMaxSpeed())
                {
                    fastestVehicle = vehicle;
                }
            }
            Console.WriteLine($"Загальна сума податків: {totalTax} грн");
            Console.WriteLine($"Найшвидший транспорт: {fastestVehicle.Brand} {fastestVehicle.Model} ({fastestVehicle.GetMaxSpeed()} км/год)");
        }
    }
}
