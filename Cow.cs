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

public class Highland : Cow
{
  public bool HairShake;

  public Highland(bool hairShake)
  {
    HairShake = hairShake;
  }

  public void ShakeHair()
  {
    Console.WriteLine(HairShake ? "This Highland is shaking their hair" : "This Highland doesn't want to shake their hair")
  }
}

public class Angus : Cow
{
  public bool BlackCoat;

  public Angus()
  {
    HasHorns = false;
    BlackCoat = true;
  }

  public void HasBlackCoat()
  {
    Console.WriteLine(BlackCoat ? "This Angus has blackcoat" : "This Angus has another coat color");
  }

}
