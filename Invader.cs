namespace TreehouseDefense
{
  class Invader
  {
 
    private int _pathStep = 0;
    private readonly Path _path;
    public MapLocation Location =>_path.GetLocationAt(_pathStep);
    
                                  
    public Invader(Path path)
    {
      _path = path;
     // Location = _path.GetLocationAt(0);
    }
    
    public int Health {get; private set;} = 2;
    
    // True if the invader has reached the end of a path
    public bool HasScored => _pathStep >= _path.Length;
    public bool IsNeutralized => Health <=0;
    public bool IsActive => (!IsNeutralized || HasScored);
    public void Move() => _pathStep++;
    public void DecreaseHealth(int factor)
    {
      Health -= factor;
    }
  }
}