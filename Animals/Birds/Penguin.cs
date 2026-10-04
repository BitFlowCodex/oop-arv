public class Penguin : Bird
{
  public bool Sliding;

  public Penguin(bool sliding)
  {
    Sliding = sliding;
    CanFly = false;
  }

  public void Slide()
  {
    Console.WriteLine(Sliding ? "The penguin is sliding" : "The penguin isn't sliding");
  }
}