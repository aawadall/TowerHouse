using System;

namespace TreehouseDefense
{
    class Game
    {
        public static void Main()
        {
          Map map = new Map(8,5);
          try
          {
            Path path = new Path(
              new [] {
                new MapLocation(0,2,map),
                new MapLocation(1,2,map),
                new MapLocation(2,2,map),
                new MapLocation(3,2,map),
                new MapLocation(4,2,map),
                new MapLocation(5,2,map),
                new MapLocation(6,2,map),
                new MapLocation(7,2,map)
              }
            );
            
            Invader[] invaders = 
            {
              new Invader(path),
              new Invader(path),
              new Invader(path),
              new Invader(path)
            };
            
            Tower[] towers = {
              new Tower(new MapLocation(1,3,map)),
              new Tower(new MapLocation(3,3,map)),
              new Tower(new MapLocation(5,3,map))
            };
            Level level = new Level(invaders)
            {
              Towers = towers
            };
            
            bool PlayerWon = level.Play();
            
            Console.WriteLine("Player "+ (PlayerWon?"Won!":"Lost!"));
            Console.ReadLine();

          }
          catch(OutOfBoundsException ex)
          {
            Console.WriteLine(ex.Message);
          }
          catch(TreehouseDefenseException )
          {
            Console.WriteLine("Unhandled Treehouse Defense exception!");
          }
          catch(Exception ex)
          {
             Console.WriteLine("Unhandled exception!" + ex);
            
          }
          /*
          Point point = new Point(4,2);
          Point point2= new Point(4,4);
          
          Console.WriteLine(point.DistanceTo(5,5));
          Console.WriteLine(point.DistanceTo(point2));
          */
      
        }
    }
}
