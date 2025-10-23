using System;

namespace CarLotSimulator
{
    class Program
    {
        static void Main(string[] args)
        {
            var carLotOne = new CarLot();

            var carOne = new Car();
            carOne.Make = "Chrysler";
            carOne.Model = "Thunderbolt Roadster";
            carOne.Year = 1941;
            carOne.IsDriveable = true;
            carLotOne.ParkingLot.Add(carOne);
            Console.WriteLine($"Number of cars in lot: {CarLot.numberOfCars}");

            var carTwo = new Car()
            {
                Make = "Mercury",
                Model = "Club Coupe",
                Year = 1940,
                IsDriveable = true
            };
            carLotOne.ParkingLot.Add(carTwo);
            Console.WriteLine($"Number of cars in lot: {CarLot.numberOfCars}");

            var carThree = new Car("Studebaker", "Champion", 1948, true);
            carLotOne.ParkingLot.Add(carThree);
            Console.WriteLine($"Number of cars in lot: {CarLot.numberOfCars}");

            carLotOne.CheckCars();
        }
    }
}