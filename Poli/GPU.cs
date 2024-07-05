namespace Poli;

public class GPU : Device
{
  public GPU() : base("GPU")
  { }

  public override string Start()
  {
    return $"{Name} is generating graphics...";
  }

  public override string Stop()
  {
    return $"{Name} is stopping...";
  }
}