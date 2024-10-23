namespace Practice3
{
    public class Taxi
    {
        private static Taxi instance; // Static instance of class taxi (Singleton)

        private double health;
        private double speed;
        private bool isDebuffed;

        private double lastLifeValue;
        private double lastSpeedValue;

        public Taxi()
        {
            Health = 100;
            Speed = 1;
            IsDebuffed = false;

            lastLifeValue = Health; // We initialize the last values with the current values
            lastSpeedValue = Speed; 
        }

        public static Taxi GetInstance() // Method to obtain the Taxi instance
        {
            if (instance == null)
            {
                instance = new Taxi();
            }
            return instance;
        }

        public double Speed
        {
            get { return speed; }
            protected set { speed = value; }
        }

        public double Health
        {
            get { return health; }
            set
            {
                if (value < 0)
                    throw new ArgumentOutOfRangeException("Los puntos de vida no pueden ser negativos.");
                health = value;
            }
        }
        public bool IsDebuffed
        {
            get { return isDebuffed; }
            private set { isDebuffed = value; }
        }

        private void CheckTaxiValues() // Function to display the values ​​of the taxi, for now it is private because we only use it within this class
        {
            if (health != lastLifeValue || speed != lastSpeedValue) // Only print if there is a change
            {
                Console.WriteLine($"{DateTimeOffset.Now.ToUnixTimeMilliseconds()}-> Vida: {health}, Velocidad: {speed}");
                lastLifeValue = health; // Update the last value
                lastSpeedValue = speed; 
            }
        }

        // Functions that change class parameters due to impacts with obstacles
        public void TakeDamage(double damage)
        {
            Health -= damage;
            CheckTaxiValues();
        }

        public void ApplySpeedDebuff(double debuffAmount)
        {
            Speed -= debuffAmount;
            IsDebuffed = true;
            CheckTaxiValues();
        }

        public void RestoreSpeed(double originalSpeed)
        {
            Speed = originalSpeed; 
            IsDebuffed = false;
            CheckTaxiValues();
        }


    }

}