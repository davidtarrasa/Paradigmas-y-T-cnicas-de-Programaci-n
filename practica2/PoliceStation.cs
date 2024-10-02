namespace Practice2
{
    class PoliceStation : IMessageWriter
    {
        private List<PoliceCar> policeCars;
        private bool activeAlert;
        private string alertedPlate;

        public PoliceStation()
        {
            policeCars = new List<PoliceCar>();
            activeAlert = false;
            alertedPlate = "";
            Console.WriteLine(WriteMessage("Police Station created."));
        }

        public void RegisterPoliceCar(PoliceCar car)
        {
            policeCars.Add(car);
            Console.WriteLine(WriteMessage($"Police car with plate {car.GetPlate()} registered."));
        }

        public void ActivateAlert(string infractorPlate)
        {
            activeAlert = true;
            alertedPlate = infractorPlate;
            Console.WriteLine(WriteMessage($"Alert activated for vehicle with plate {infractorPlate}."));
            NotifyAllPoliceCars();
        }

        private void NotifyAllPoliceCars()
        {
            foreach (var car in policeCars)
            {
                if (car.IsPatrolling())
                {
                    Console.WriteLine(car.WriteMessage($"Pursuing vehicle with plate {alertedPlate}."));
                }
            }
        }

        public string WriteMessage(string message)
        {
            return $"Police Station: {message}";
        }
    }
}


