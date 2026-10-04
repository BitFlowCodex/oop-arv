public class Cow : Animal
{
  public bool HasHorns;

  public Cow()
  {
    Sound = "Moo";
    RestHours = "5";
    Diet = "Herbivore";
    Movement = "Walking and running";
    Habitat = "Grasslands";
    Species = "Cow";
    HasHorns = true;
  }

  public void Horns()
  {
    Console.WriteLine(HasHorns ? "This Cow has horns" : "This Cow doesn't have horns");
  }
}
