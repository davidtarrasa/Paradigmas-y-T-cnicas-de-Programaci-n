namespace Practice3
{
    public class SpeedDebuffCreator: ObstacleCreator
    {
        public override SpeedDebuff CreateObstacle() // Implementation of the CreateObstacle method
        {
            return new SpeedDebuff();
        }
    }
}