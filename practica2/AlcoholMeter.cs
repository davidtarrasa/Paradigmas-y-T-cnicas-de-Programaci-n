using System;

namespace Practice2
{
    public class AlcoholMeter : IMeasuringDevice
    {
        private float lastMeasurement;

        public void Measure(Vehicle vehicle)
        {
            
            lastMeasurement = new Random().Next(0, 2); // Simulate result ( 0 - 1 )
            Console.WriteLine($"Measured alcohol level: {lastMeasurement} for vehicle {vehicle.GetPlate()}");
        }

        public string GetLastMeasurement()
        {
            return $"Last alcohol measurement: {lastMeasurement}";
        }
    }
}

