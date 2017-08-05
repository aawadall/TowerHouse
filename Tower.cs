namespace TreehouseDefense
{
  class Tower
  {
    private readonly MapLocation _location;
    private const int _range =1;
    private const int _power =1;
    private const double _accuracy = 0.75;
    private static readonly System.Random _random = new System.Random();
    public Tower(MapLocation Location)
    {
      _location = Location;
    }
    
    public bool IsSuccessfulShot() => _random.NextDouble() < _accuracy;
    public void FireOnInvaders(Invader[] invaders)
    {
      foreach(Invader invader in invaders)
      {
        // do stuff
        if( invader.IsActive && 
            _location.InRangeOf(invader.Location,_range)    )
        {
          if(IsSuccessfulShot())
          {
            invader.DecreaseHealth(_power);
            System.Console.WriteLine("Shot and hit an invader!");
            if (invader.IsNeutralized)
            {
              System.Console.WriteLine("Neutralized this invader!!!! :D");
            }
          }
          else
          {
            System.Console.WriteLine("Missed :(");
          }
          break;
        }
      }
    }
  }
}