namespace Practice3
{
    public class Taxi
    {
        private static Taxi instance; // Instancia estática de la clase Taxi

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

            lastLifeValue = Health; // Inicializamos el último valor con el valor actual
            lastSpeedValue = Speed; // Inicializamos el último valor con el valor actual
        }

        public static Taxi GetInstance() // Método para obtener la instancia del Taxi
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

        private void CheckTaxiValues() // Método para mostrar los valores del taxi, por ahora es privado porque solo lo utilizamos dentro de esta clase
        {
            if (health != lastLifeValue || speed != lastSpeedValue) // Solo imprime si hay un cambio
            {
                Console.WriteLine($"{DateTimeOffset.Now.ToUnixTimeMilliseconds()}-> Vida: {health}, Velocidad: {speed}");
                lastLifeValue = health; // Actualiza el último valor
                lastSpeedValue = speed; // Actualiza el último valor
            }
        }

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