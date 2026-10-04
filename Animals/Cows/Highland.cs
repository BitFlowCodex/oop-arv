public class Highland : Cow
{
  public bool HairShake;

  public Highland(bool hairShake)
  {
    HairShake = hairShake;
  }

  public void ShakeHair()
  {
    Console.WriteLine(HairShake ? "This Highland is shaking their hair" : "This Highland doesn't want to shake their hair");
  }
}