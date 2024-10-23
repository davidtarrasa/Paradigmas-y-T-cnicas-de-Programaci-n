namespace Practice3
{
    public class ConstructionFenceCreator: ObstacleCreator
    {
        public override ConstructionFence CreateObstacle() // Implementation of the CreateObstacle method
        {
            return new ConstructionFence();
        }
    }
}