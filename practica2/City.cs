namespace Practice2
{
    class City
    {
        private PoliceStation policeStation;
        private List<Taxi> registeredTaxis;

        public City(PoliceStation station)
        {
            policeStation = station;
            registeredTaxis = new List<Taxi>();
        }

        public void RegisterTaxi(Taxi taxi)
        {
            registeredTaxis.Add(taxi);
            Console.WriteLine($"Taxi with plate {taxi.GetPlate()} registered in the city.");
        }

        public void RemoveTaxi(Taxi taxi)
        {
            registeredTaxis.Remove(taxi);
            Console.WriteLine($"Taxi with plate {taxi.GetPlate()} removed from the city.");
        }
    }
}
