public class Animal
{
  public string Sound = "";
  public string RestHours = "";
  public string Diet = "";
  public string Movement = "";
  public string Habitat = "";
  public string Species = "";

  public Animal() { }

  public void MakeSound()
  {
    Console.WriteLine($"{Species} goes {Sound}");
  }

  public void Sleep()
  {
    Console.WriteLine($"{Species} sleeps for {RestHours} hours");
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