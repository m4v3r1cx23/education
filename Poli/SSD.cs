namespace Poli;

public class SSD : Device
{
  public SSD() : base("SSD")
  { }

  public override string Start()
  {
    return $"{Name} is storing data...";
  }

  public override string Stop()
  {
    return $"{Name} is stopping...";
  }
}