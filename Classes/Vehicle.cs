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
            if (string.IsNullOrWhiteSpace(brand))
            {
                throw new ArgumentException("Рядок \"Марка авто\" не може бути порожнім!");
            }
            if (string.IsNullOrWhiteSpace(model))
            {
                throw new ArgumentException("Рядок \"Модель авто\" не може бути порожнім!");
            }
            // 1885 - рік появи першого авто
            if (year < 1885 || year > DateTime.Now.Year)
            {
                throw new ArgumentOutOfRangeException(nameof(year),$"Рік випуску транспорту має бути в межах від 1885 до {DateTime.Now.Year}.");
            }
            if (price < 0)
            {
                throw new ArgumentOutOfRangeException(nameof(price),"Ціна не може бути від'ємною!");
            }
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
