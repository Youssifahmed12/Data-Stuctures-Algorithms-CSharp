using System;
using System.Collections.Generic;


namespace TrafficLights
{

    class TrafficLight
    {
        Queue<string> Traffic = new Queue<string>();
        public void AddVehicleToTraffic(string car)
        {
            Traffic.Enqueue(car);
        }
        public void simulate()
        {
            while (Traffic.Count > 0)
            {
                Console.WriteLine($"Current Vehicle:{Traffic.Peek()}");
                Traffic.Dequeue();
                Console.WriteLine($"Remaining Vehicles :{ string.Join(", ", Traffic)}");
            }
            Console.WriteLine("No Vehicles Left");
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            TrafficLight trafficLight = new TrafficLight();
            
            trafficLight.AddVehicleToTraffic("Car");
            trafficLight.AddVehicleToTraffic("Motorcycle");
            trafficLight.AddVehicleToTraffic("Truck");
            trafficLight.AddVehicleToTraffic("Heavy Truck");

            trafficLight.simulate();

            Console.ReadKey();
        }
    }
}
