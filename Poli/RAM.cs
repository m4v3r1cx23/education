
namespace Poli;

public class RAM : Device
{
  public RAM() : base("RAM")
  { }

  public override string Start()
  {
    return $"{Name} is starting to remmember...";
  }

  public override string Stop()
  {
    return $"{Name} is stopping...";
  }
}