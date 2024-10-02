namespace Practice2
{
    internal class Program
    {
        static void Main()
        {
            // Create a city and a policestation
            City city = new City();
            PoliceStation policeStation = new PoliceStation();

            // Create and register a taxi
            Taxi taxi1 = new Taxi("0001 AAA");
            Taxi taxi2 = new Taxi("0002 BBB");
            city.RegisterTaxi(taxi1);
            city.RegisterTaxi(taxi2);
            Console.WriteLine(taxi1.WriteMessage("Taxi created."));
            Console.WriteLine(taxi2.WriteMessage("Taxi created."));

            //Create and register police cars with or without radar 
            PoliceCar policeCar1 = new PoliceCar("0001 CNP");
            PoliceCar policeCar2 = new PoliceCar("0002 CNP");
            policeCar2.SetRadar(new SpeedRadar()); // Solo el segundo coche tiene radar
            city.RegisterPoliceCar(policeCar1);
            city.RegisterPoliceCar(policeCar2);
            Console.WriteLine(policeCar1.WriteMessage("Police car created."));
            Console.WriteLine(policeCar2.WriteMessage("Police car created with radar."));

            // Police car number one starts patrolling
            policeCar1.StartPatrolling();
            Console.WriteLine(policeCar1.WriteMessage("started patrolling."));

            // The police car one has seen taxi one and uses de radar 
            policeCar1.UseRadar(taxi1);

            taxi2.StartRide();
            Console.WriteLine(taxi2.WriteMessage("is now carrying passengers."));


            policeCar2.UseRadar(taxi2);
            Console.WriteLine(policeCar2.WriteMessage("attempted to use radar without patrolling."));

            policeCar2.StartPatrolling();
            Console.WriteLine(policeCar2.WriteMessage("started patrolling."));

            policeCar2.UseRadar(taxi2);

            policeCar2.StartPursuit(taxi2);
            policeStation.ActivateAlert(taxi2.GetPlate()); // Notificar a la comisaría

            taxi2.StopRide();
            Console.WriteLine(taxi2.WriteMessage("has finished the ride."));

            policeCar2.EndPatrolling();
            Console.WriteLine(policeCar2.WriteMessage("has stopped patrolling."));

            taxi1.StartRide();
            Console.WriteLine(taxi1.WriteMessage("is now carrying passengers."));

            taxi1.StartRide(); 
            Console.WriteLine(taxi1.WriteMessage("attempted to start a new ride while already carrying passengers."));

            policeCar1.StartPatrolling();
            Console.WriteLine(policeCar1.WriteMessage("started patrolling again."));


            policeCar1.UseRadar(taxi1);

            taxi1.StopRide();
            Console.WriteLine(taxi1.WriteMessage("has finished the ride."));

            policeCar1.EndPatrolling();
            Console.WriteLine(policeCar1.WriteMessage("has stopped patrolling."));

            policeCar1.PrintRadarHistory();
            policeCar2.PrintRadarHistory();

            Console.WriteLine("All scenarios executed. Press any key to exit.");
            Console.ReadKey();
        }
    }
}
