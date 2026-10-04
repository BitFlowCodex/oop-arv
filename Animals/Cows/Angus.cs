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