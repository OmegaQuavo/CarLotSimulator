using System;

namespace CarLotSimulator;
using System.Collections.Generic;

public class CarLot
{
    public List<Car> ParkingLot { get; set; }  = new List<Car>();

    public void CheckCars()
    {
        foreach (var vehicle in ParkingLot)
        {
            Console.WriteLine($"{vehicle.Make} {vehicle.Model} {vehicle.Year}");
        }
    }
}