using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    public class Truck : Vehicle
    {
        public double LoadCapacity { get; set; } // (вантажопідйомність у тоннах)
        public int NumberOfAxles { get; set; }   // (кількість осей)
        public Truck(string brand, string model, int year, double price, double loadCapacity, int numberOfAxles)
            : base(brand, model, year, price)
        {
            LoadCapacity = loadCapacity;
            NumberOfAxles = numberOfAxles;
        }
        public override void DisplayInfo()
        {
            Console.WriteLine($"Вантажівка: {Brand} {Model} {Year}");
            Console.WriteLine($"Ціна: {Price} грн");
            Console.WriteLine($"Вантажопідйомність: {LoadCapacity} тонн");
            Console.WriteLine($"Кількість осей: {NumberOfAxles}");
            Console.WriteLine($"Максимальна швидкість: {GetMaxSpeed()} км/год");
            Console.WriteLine($"Транспортний податок: {CalculateTax()} грн");
            Console.WriteLine();
        }
        public override double CalculateTax()
        {
            return Price * 0.02 + LoadCapacity * 1000;
        }
        public override double GetMaxSpeed()
        {
            return 120;
        }
    }
}
