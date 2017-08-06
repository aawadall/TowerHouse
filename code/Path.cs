namespace TreehouseDefense
{
  public class Path
  {
    private readonly MapLocation[] _path;
    
    public Path(MapLocation[] path)
    {
      this._path = path;
    }
    
    public MapLocation GetLocationAt(int pathSteps)
    {
       return (pathSteps < _path.Length)? _path[pathSteps]:null;
    }
    
    public int Length =>  _path.Length-1;
    
  }
}
