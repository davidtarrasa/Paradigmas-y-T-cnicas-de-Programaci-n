namespace Practice3
{
    public class ConstructionFence : Obstacle
    {
        public ConstructionFence()
        {
            Chasing = false; 
            Solid = true; 
            PtsHealth = 10; 
            MultVelocity = 0.8; 
        }

        public override void CheckCollision()
        {
            Console.WriteLine($"Comprobando colisión con la construction fence");
        }
    }


}