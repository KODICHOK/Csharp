using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace Lb8
{
    public class Car
{
    public string? mark { get; }
    public string? Color { get; }
    public string? Speed { get; }
    public string? Year { get; 
}

    public Car(string? brandCar, string? colorCar, string? speedCar, string? yearManufactureCar)
    {
        mark = brandCar;
        Color = colorCar;
        Speed = speedCar;
        Year = yearManufactureCar;
    }

    public void GetCarData()
    {
        Console.WriteLine(
            $"Марка: {mark} Колір: {Color} Швидкість: {Speed} Рік випуску: {Year}");
    }
}

public class Garage
{
    public List<Car> Cars { get; } = new();

    public void Init()
    {
        AddCar(new Car("Pagany", "black", "400 ", "2018"));
        AddCar(new Car("Ferrari", "red", "400 ", "2020"));
    }

    public void AddCar(Car car)
    {
        Cars.Add(car);
    }

    public void RemoveCar(Car car)
    {
        Cars.Remove(car);
    }

    public void ShowAutoPark()
    {
        Console.WriteLine("Ваш автопарк:");
        for (int i = 0; i < Cars.Count; i++)
        {
            Console.WriteLine($"індекс машини - {i}");
            Cars[i].GetCarData();
        }
    }

    private List<Car> SearchCarByParameters(string parameters, IEnumerable<Car> cars)
    {
        return cars.Where(car =>
            parameters == car.mark || parameters == car.Color || parameters == car.Speed||
            parameters == car.Year).ToList();
    }
}
    
    public static class Program
    {
        private static void Main()
        {
            var garage = new Garage();
            garage.Init();
            garage.ShowAutoPark();


            Console.WriteLine("Вітаю мій Шейхе, ви бажаєте купити чи позбутись якогось автомобіли?");
            Console.WriteLine(" покупка - 1 \n позбутись - 2 \n");
            int solution = int.Parse(Console.ReadLine() ?? string.Empty);
            switch (solution)
            {
                case 1:
                    BuyCar(garage);
                    break;
                case 2:
                    CostOutCar(garage);
                    break;
            }
        }

        private static void CostOutCar(Garage garage)
        {
            Console.WriteLine("Бувай ще один автомобіль, виберіть індекс автомобіля якого бажаєте позбутись.");
            int carIndex = int.Parse(Console.ReadLine() ?? string.Empty);
            garage.RemoveCar(garage.Cars[carIndex]);
            garage.ShowAutoPark();
        }

        private static void BuyCar(Garage garage)
        {
            Console.WriteLine("Марка машини");
            string? carBrand = Console.ReadLine();

            Console.WriteLine("Колір");
            string? carColor = Console.ReadLine();

            Console.WriteLine("Швидкість");
            string? carSpeed = Console.ReadLine();

            Console.WriteLine("Рік випуску");
            string? carYearManufacture = Console.ReadLine();

            var newCar = new Car(carBrand, carColor, carSpeed, carYearManufacture);
            garage.AddCar(newCar);
            garage.ShowAutoPark();
        }
    }
}