namespace Practice2
{
    class PoliceStation
    {
        private List<PoliceCar> policeCars;
        private bool activeAlert;
        private string alertedPlate;

        public PoliceStation()
        {
            policeCars = new List<PoliceCar>();
            activeAlert = false;
        }

        public void RegisterPoliceCar(PoliceCar car)
        {
            policeCars.Add(car);
            Console.WriteLine($"Police car with plate {car.GetPlate()} registered in the station.");
        }

        public void ActivateAlert(string infractorPlate)
        {
            activeAlert = true;
            alertedPlate = infractorPlate;
            NotifyAllPoliceCars();
        }

        private void NotifyAllPoliceCars()
        {
            foreach (PoliceCar car in policeCars)
            {
                if (car.IsPatrolling())
                {
                    car.Pursue(alertedPlate);
                }
            }
        }
    }
}
