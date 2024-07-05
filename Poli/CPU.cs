namespace Poli;

public class CPU : Device
{
  public CPU() : base("CPU")
  { }

  public override string Start()
  {
    return $"{Name} is starting to process data...";
  }

  public override string Stop()
  {
    return $"{Name} is stopping...";
  }
}