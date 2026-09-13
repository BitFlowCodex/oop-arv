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
