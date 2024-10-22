namespace Practice3
{
    public class PoliceCarCreator: ObstacleCreator
    {
        public override PoliceCar CreateObstacle()
        {
            return new PoliceCar(); 
        }
    }
}