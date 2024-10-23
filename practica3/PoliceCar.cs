namespace Practice3
{
    public class PoliceCar : Obstacle
    {
        public PoliceCar()
        {
            Chasing = true;
            Solid = true;
            PtsHealth = 30;
            MultVelocity = 0.8; // Reduces velocity
        }

        public override void CheckCollision() // Override method to check collision with taxi
        {
            Console.WriteLine($"Comprobando colisión con policia");
        }
    }
}


