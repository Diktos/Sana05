using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    public class Vehicle
    {
        public string Brand { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public double Price { get; set; }
        public Vehicle(string brand, string model, int year, double price)
        {
            Brand = brand;
            Model = model;
            Year = year;
            Price = price;
        }
        public virtual void DisplayInfo()
        {
            Console.WriteLine($"Марка: {Brand}");
            Console.WriteLine($"Модель: {Model}");
            Console.WriteLine($"Рік випуску: {Year}");
            Console.WriteLine($"Ціна: {Price} грн");
            Console.WriteLine();
        }
        public virtual double CalculateTax()
        {
            return Price * 0.01;
        }
        public virtual double GetMaxSpeed()
        {
            return 100;
        }
    }
}
