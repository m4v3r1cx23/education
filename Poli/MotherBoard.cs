
namespace Poli;

public class MotherBoard : Device
{
  public MotherBoard() : base("MotherBoard")
  { }

  public override string Start()
  {
    return $"{Name} is initializing BIOS...";
  }

  public override string Stop()
  {
    return $"{Name} is stopping...";
  }
}