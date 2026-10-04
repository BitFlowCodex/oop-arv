public class Human : Animal
{
  public string Name { get; set; } = "";
  public bool LikesCoffee { get; set; }

  public Human()
  {
    Sound = "Hello";
    RestHours = "6-8";
    Diet = "Omnivore";
    Movement = "Walking, running and jumping";
    Habitat = "Cities and houses";
    Species = "Human";
  }

  public void DrinkCoffee()
  {
    Console.WriteLine(LikesCoffee
    ? $"{Name} is drinking coffee"
    : $"{Name} doesn't like coffee, so they're drinking something else"
    );
  }
}