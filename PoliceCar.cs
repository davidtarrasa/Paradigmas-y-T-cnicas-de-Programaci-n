namespace Practice2
{
    public class PoliceCar : Vehicle
    {
        private const string typeOfVehicle = "Police Car";
        private bool isPatrolling;
        private bool isPursuing;
        private SpeedRadar speedRadar;

        
        public PoliceCar(string plate) : base(typeOfVehicle, plate)
        {
            isPatrolling = false;
            isPursuing = false;
            speedRadar = new SpeedRadar(); 
        }

        public void SetRadar(SpeedRadar radar)
        {
            speedRadar = radar;
        }

        public void UseRadar(Vehicle vehicle)
        {
            if (isPatrolling && speedRadar != null)
            {
                speedRadar.TriggerRadar(vehicle);
                string measurement = speedRadar.GetLastReading();
                Console.WriteLine(WriteMessage($"Triggered radar. Result: {measurement}"));
            }
            else if (speedRadar == null)
            {
                Console.WriteLine(WriteMessage("has no radar attached."));
            }
            else
            {
                Console.WriteLine(WriteMessage("has no active radar."));
            }
        }

        public void StartPursuit(Vehicle vehicle)
        {
            if (vehicle.GetSpeed() > speedRadar.LegalSpeed)
            {
                isPursuing = true;
                Console.WriteLine(WriteMessage($"is now pursuing {vehicle.GetTypeOfVehicle()} with plate {vehicle.GetPlate()}"));
            }
        }

        public bool IsPatrolling() => isPatrolling;

        public void StartPatrolling()
        {
            if (!isPatrolling)
            {
                isPatrolling = true;
                Console.WriteLine(WriteMessage("started patrolling."));
            }
            else
            {
                Console.WriteLine(WriteMessage("is already patrolling."));
            }
        }

        public void EndPatrolling()
        {
            if (isPatrolling)
            {
                isPatrolling = false;
                Console.WriteLine(WriteMessage("stopped patrolling."));
            }
            else
            {
                Console.WriteLine(WriteMessage("was not patrolling."));
            }
        }

        public void PrintRadarHistory()
        {
            Console.WriteLine(WriteMessage("Report radar speed history:"));
            if (speedRadar != null)
            {
                foreach (float speed in speedRadar.SpeedHistory)
                {
                    Console.WriteLine(speed);
                }
            }
            else
            {
                Console.WriteLine(WriteMessage("No radar history available."));
            }
        }
    }
}
