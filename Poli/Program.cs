using Poli;

var devinces = new List<Device> {
  new MotherBoard(),
  new CPU(),
  new RAM(),
  new SSD(),
  new GPU()
};

foreach (var device in devinces)
{
  Console.WriteLine(device.Start());
}

devinces.Reverse();

foreach (var device in devinces)
{
  Console.WriteLine(device.Stop());
}