using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpeedRacing
{
    class Car
    {
        public string modelcar;
        public double fuelAmount;
        public double fuelCost;
        public double distanceTravaled;
        public HashSet<string> cars;



        public Car(string modelcar, double fuelAmount, double fuelCost, double distanceTravaled)
        {
            this.modelcar = modelcar;
            this.fuelAmount = fuelAmount;
            this.fuelCost = fuelCost;
            this.distanceTravaled = distanceTravaled;
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            var numberCars = int.Parse(Console.ReadLine());
            var allCars = new List<Car>();
            var cars = new HashSet<string>();
            for (int i = 0; i < numberCars; i++)
            {
                var carParameters = Console.ReadLine().Split();
                if (!cars.Contains(carParameters[0]))
                {
                    var car = new Car(
                        carParameters[0],
                        double.Parse(carParameters[1]),
                        double.Parse(carParameters[2]),
                        0
                        );

                    cars.Add(carParameters[0]);
                    allCars.Add(car);
                }
            }

            var moveCar = Console.ReadLine();

            while (moveCar != "End")
            {
                var parts = moveCar.Split(' ');

                var model = parts[1];
                var distance = double.Parse(parts[2]);

                foreach (var car1 in allCars)
                {
                    if (car1.modelcar == model)
                    {
                        var fuel = car1.fuelCost * distance;
                        if (fuel > car1.fuelAmount)
                        {
                            Console.WriteLine("Insufficient fuel for the drive");
                        }
                        else
                        {
                            car1.fuelAmount = car1.fuelAmount - fuel;
                            car1.distanceTravaled = car1.distanceTravaled + distance;

                            var car = new Car(
                                car1.modelcar,
                                car1.fuelAmount,
                                car1.fuelCost,
                                car1.distanceTravaled
                                );
                        }
                    }
                }
                moveCar = Console.ReadLine();
            }

            foreach (var car in allCars)
            {
                Console.WriteLine($"{car.modelcar} {car.fuelAmount:f2} {car.distanceTravaled}");
            }
        }
    }
}
