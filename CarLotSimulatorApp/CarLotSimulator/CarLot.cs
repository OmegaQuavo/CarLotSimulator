using System;
using System.Collections.Generic;

namespace CarLotSimulator
{
    public class CarLot
    {
        // Static field to track number of cars created
        public static int numberOfCars = 0;

        public List<Car> ParkingLot { get; set; } = new List<Car>();

        public void CheckCars()
        {
            foreach (var vehicle in ParkingLot)
            {
                Console.WriteLine($"{vehicle.Year} {vehicle.Make} {vehicle.Model}");
            }
        }
    }
}