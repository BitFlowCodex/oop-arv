public class Animal
{
  public required string Sound;
  public required string Rest;
  public required string Diet;
  public required string Movement;
  public required string Habitat;
  public required string Family;
  public required string Species;

  public Animal(string sound, string rest, string diet, string movement, string habitat, string species)
  {
    Sound = sound;
    Rest = rest;
    Diet = diet;
    Movement = movement;
    Habitat = habitat;
    Species = species;
  }

  public void MakeSound()
  {
    Console.WriteLine($"{Species} goes {Sound}");
  }

  public void Sleep()
  {
    Console.WriteLine($"{Species} sleeps for {Rest}");
  }

  public void Eat()
  {
    Console.WriteLine($"{Species} Eats {Diet}");
  }

  public void Move()
  {
    Console.WriteLine($"{Species} moves by {Movement} in the {Habitat}");
  }

}