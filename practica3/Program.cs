using System;
using System.Collections.Generic;

namespace Practice3
{
    internal class Program
    {
        static void Main()
        {
            Console.WriteLine("Press a key to create an obstacle:");
            Console.WriteLine("A -> PoliceCar");
            Console.WriteLine("D -> ConstructionFence");
            Console.WriteLine("0 -> SpeedDebuff");

            double startTime = DateTimeOffset.Now.ToUnixTimeMilliseconds() / 1000.0;
            double lastTimeStamp = 0.0;

            List<Obstacle> obstacles = new List<Obstacle>(); 

            while (true)
            {
                double timeStamp = DateTimeOffset.Now.ToUnixTimeMilliseconds() / 1000.0 - startTime;

                if (timeStamp - lastTimeStamp >= 0.02)
                {
                    lastTimeStamp = timeStamp;

                    
                    foreach (var obstacle in obstacles)
                    {
                       
                        obstacle.CheckCollision();
                    }

                    if (Console.KeyAvailable)
                    {
                        ConsoleKeyInfo key = Console.ReadKey(true);
                        switch (key.Key)
                        {
                            case ConsoleKey.A:
                                obstacles.Add(new PoliceCarCreator().CreateObstacle());
                                // Console.WriteLine("All scenarios executed. Press any key to exit.");
                                break;
                            case ConsoleKey.D:
                                obstacles.Add(new ConstructionFenceCreator().CreateObstacle());
                                break;
                            case ConsoleKey.NumPad0:
                                obstacles.Add(new SpeedDebuffCreator().CreateObstacle());
                                break;
                            default:
                                break;
                        }
                    }
                }      
            }                
        }
    }
}



