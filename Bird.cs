public class Bird : Animal
{
  public bool CanFly;

  public Bird()
  {
    Sound = "Chirp";
    RestHours = "10";
    Diet = "Omnivore";
    Movement = "Walking, jumping and flying";
    Habitat = "Forests";
    Species = "Bird";
    CanFly = true;
  }

  public void Fly()
  {
    Console.WriteLine(CanFly ? "This bird is flying" : "This bird can't fly");
  }
}

public class Parrot : Bird
{
  public string? SpokenMessage;

  public Parrot(string spokenMessage)
  {
    SpokenMessage = spokenMessage;
  }

  public void Speak()
  {
    Console.WriteLine(SpokenMessage);
  }

}

public class Penguin : Bird
{
  public bool Sliding;

  public Penguin(bool sliding)
  {
    Sliding = sliding;
  }

  public void Slide()
  {
    Console.WriteLine(Sliding ? "The penguin is sliding" : "The penguin isn't sliding");
  }
}