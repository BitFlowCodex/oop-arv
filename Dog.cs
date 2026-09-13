public class Dog : Animal
{
  public bool CanFetch;

  public Dog()
  {
    Sound = "woof woof";
    RestHours = "12";
    Diet = "Omnivore";
    Movement = "Walking, running and jumping";
    Habitat = "Households";
    Species = "Dog";
    CanFetch = true;
  }

  public void Fetch()
  {
    Console.WriteLine(CanFetch ? "Can fetch it" : "Can't fetch");
  }
}
