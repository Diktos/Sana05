using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    public class Car : Vehicle
    {
        public int NumberOfDoors { get; set; }
        public FuelType FuelType { get; set; }
        public Car(string brand, string model, int year, double price, int numberOfDoors, FuelType fuelType)
            : base(brand, model, year, price)
        {
            NumberOfDoors = numberOfDoors;
            FuelType = fuelType;
        }
        public override void DisplayInfo()
        {
            Console.WriteLine($"Легковий автомобіль: {Brand} {Model} {Year}");
            Console.WriteLine($"Ціна: {Price} грн");
            Console.WriteLine($"Кількість дверей: {NumberOfDoors}");

            string fuelType = string.Empty;
            switch (FuelType)
            {
                case FuelType.Petrol: fuelType = "Бензин"; break;
                case FuelType.Diesel: fuelType = "Дизель"; break;
                case FuelType.Electric: fuelType = "Електро"; break;
                default: fuelType = "Бензин"; break;
            }

            Console.WriteLine($"Тип палива: {fuelType}");
            Console.WriteLine($"Максимальна швидкість: {GetMaxSpeed()} км/год");
            Console.WriteLine($"Транспортний податок: {CalculateTax()} грн");
            Console.WriteLine();
        }
        public override double CalculateTax()
        {
            if (FuelType == FuelType.Electric)
            {
                return Price * 0.005;
            }
            return Price * 0.015;
        }
        public override double GetMaxSpeed()
        {
            return 180;
        }
    }
}
