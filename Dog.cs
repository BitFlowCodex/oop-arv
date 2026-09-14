public class Dog : Animal
{
  public bool LikesFetch;

  public Dog()
  {
    Sound = "woof woof";
    RestHours = "12";
    Diet = "Omnivore";
    Movement = "Walking, running and jumping";
    Habitat = "Households";
    Species = "Dog";
    LikesFetch = true;
  }

  public void Fetch()
  {
    Console.WriteLine(LikesFetch ? "This dog loves fetching" : "This dog hates fetching");
  }
}

public class PitBull
{
  
}

public class GoldenRetriver()
{

}