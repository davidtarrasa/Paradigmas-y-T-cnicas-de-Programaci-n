namespace Practice3
{
    public class SpeedDebuffCreator: ObstacleCreator
    {
        public override SpeedDebuff CreateObstacle()
        {
            return new SpeedDebuff();
        }
    }

}