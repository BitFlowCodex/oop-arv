public class Parrot : Bird
{
  public string? SpokenMessage;

  public Parrot(string spokenMessage)
  {
    SpokenMessage = spokenMessage;
  }

  public void Speak()
  {
    Console.WriteLine($"This bird says: {SpokenMessage}");
  }

}