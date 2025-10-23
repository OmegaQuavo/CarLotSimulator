using System;
namespace CarLotSimulator
{
    public class Car
    {
        public int Year { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public string EngineNoise { get; set; }
        public string HonkNoise { get; set; }
        public bool IsDriveable { get; set; }

        public Car()
        {
            CarLot.numberOfCars++; // increment on creation
        }

        public Car(string make, string model, int year, bool isDriveable)
        {
            Make = make;
            Model = model;
            Year = year;
            IsDriveable = isDriveable;

            CarLot.numberOfCars++; // increment on creation
        }

        public void MakeEngineNoise(string engineNoise)
        {
            EngineNoise = engineNoise;
            Console.WriteLine($"{Make} {Model} sounds like: {EngineNoise}");
        }

        public void MakeHonkNoise(string honkNoise)
        {
            HonkNoise = honkNoise;
            Console.WriteLine($"{Make} {Model} honks like: {HonkNoise}");
        }
    }
}