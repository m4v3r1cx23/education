namespace Poli;

abstract public class Device(string name)
{
  public string Name { get; private set; } = name;

  public abstract string Start();

  public abstract string Stop();
}