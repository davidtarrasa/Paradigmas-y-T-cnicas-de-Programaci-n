namespace Practice2
{
    public class Scooter : Vehicle
    {

        public Scooter() : base("Scooter")
        {
            SetSpeed(0f);
        }

        public float GetCurrentSpeed() => GetSpeed();

    }
}

