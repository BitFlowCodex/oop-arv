public class GoldenRetriver : Dog
{
  public bool LovesWater = true;

  public GoldenRetriver(bool lovesWater)
  {
    LovesWater = lovesWater;
  }

  public void Swim()
  {
    Console.WriteLine(LovesWater ? "Splashing into the lake" : "Staying on the shore");
  }
}