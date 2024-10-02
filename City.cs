namespace Practice2
{
    class City : IMessageWriter
    {
        private PoliceStation policeStation;
        private List<Taxi> registeredTaxis;

        public City()
        {
            policeStation = new PoliceStation();
            registeredTaxis = new List<Taxi>();
            Console.WriteLine(WriteMessage("City created."));
        }

        public void RegisterTaxi(Taxi taxi)
        {
            registeredTaxis.Add(taxi);
            Console.WriteLine(WriteMessage($"Taxi with plate {taxi.GetPlate()} registered."));
        }

        public void RemoveTaxi(Taxi taxi)
        {
            registeredTaxis.Remove(taxi);
            Console.WriteLine(WriteMessage($"Taxi with plate {taxi.GetPlate()} license removed."));
        }

        public void RegisterPoliceCar(PoliceCar policeCar)
        {
            policeStation.RegisterPoliceCar(policeCar);
            Console.WriteLine(WriteMessage($"Police car with plate {policeCar.GetPlate()} registered."));
        }

        public void ActivateAlert(string infractorPlate)
        {
            policeStation.ActivateAlert(infractorPlate);
        }

        public string WriteMessage(string message)
        {
            return $"City: {message}";
        }
    }
}

