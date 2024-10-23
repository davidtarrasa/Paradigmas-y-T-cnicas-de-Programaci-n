
namespace Practice3
{
    public abstract class Obstacle
    {
        private bool chasing;
        private bool solid;
        private double ptsHealth;
        private double multVelocity;
        private double effectDuration;

        // Properties to check if the obstacle is chasing and if it is solid
        public bool Chasing
        {
            get { return chasing; }  // Getter
            set { chasing = value; } // Setter
        }

        public bool Solid
        {
            get { return solid; }
            protected set { solid = value; }
        }

        // Properties for health, velocity and effectduration points with validation with protected setter
        public double PtsHealth
        {
            get { return ptsHealth; }
            set
            {
                if (value < 0)
                    throw new ArgumentOutOfRangeException("Los puntos de vida no pueden ser negativos.");
                ptsHealth = value;
            }
        }

        public double MultVelocity
        {
            get { return multVelocity; }
            protected set { multVelocity = value; }
        }

        public double EffectDuration
        {
            get { return effectDuration; }
            protected set { effectDuration = value; }
        }

        public virtual void CheckCollision() // Common function for all the obstacles, Virtual method to check collision with the taxi
        {
            Console.WriteLine($"Comprobando colisión");
        }



    }


}