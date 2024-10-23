namespace Practice3
{
    public class PoliceCarCreator: ObstacleCreator
    {
        public override PoliceCar CreateObstacle() // Implementation of the CreateObstacle method
        {
            return new PoliceCar(); // Create and return a new instance of PoliceCar
        }
    }
}