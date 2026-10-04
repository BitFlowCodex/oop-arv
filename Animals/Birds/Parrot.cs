public class Parrot : Bird
{
  public string? SpokenMessage;

  public Parrot(string spokenMessage)
  {
    SpokenMessage = spokenMessage;
    // This bird can fly
  }

  public void Speak()
  {
    Console.WriteLine(SpokenMessage);
  }

}