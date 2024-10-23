namespace Practice3
{
    public class SpeedDebuff: Obstacle 
    {

        public SpeedDebuff()
        {
            Chasing = false;
            Solid = false; 
            PtsHealth = 0;
            MultVelocity = 0.5; 
        }

        public override void CheckCollision() // Override method to check collision with taxi
        {
            Console.WriteLine($"Comprobando colisión con speed debuff");
        }
    }


}