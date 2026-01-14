using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    public class Motorcycle : Vehicle
    {
        public double EngineVolume { get; set; } // (об'єм двигуна в см³)
        public bool HasWindshield { get; set; }  // (наявність вітрового скла: true/false)
        public Motorcycle(string brand, string model, int year, double price, double engineVolume, bool hasWindshield)
            : base(brand, model, year, price)
        {
            EngineVolume = engineVolume;
            HasWindshield = hasWindshield;
        }
        public override void DisplayInfo()
        {
            Console.WriteLine($"Мотоцикл: {Brand} {Model} {Year}");
            Console.WriteLine($"Ціна: {Price} грн");
            Console.WriteLine($"Об'єм двигуна: {EngineVolume} см³");
            Console.WriteLine($"Наявність вітрового скла: {(HasWindshield ? "Так" : "Ні")}");
            Console.WriteLine($"Максимальна швидкість: {GetMaxSpeed()} км/год");
            Console.WriteLine($"Транспортний податок: {CalculateTax()} грн");
            Console.WriteLine();
        }
        public override double CalculateTax()
        {
            return Price * 0.008 + EngineVolume * 0.5;
        }
        public override double GetMaxSpeed()
        {
            return 200;
        }
    }
}
