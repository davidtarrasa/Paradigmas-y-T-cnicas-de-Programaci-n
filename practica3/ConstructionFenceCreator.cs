namespace Practice3
{
    public class ConstructionFenceCreator: ObstacleCreator
    {
        public override ConstructionFence CreateObstacle()
        {
            return new ConstructionFence();
        }
    }
}