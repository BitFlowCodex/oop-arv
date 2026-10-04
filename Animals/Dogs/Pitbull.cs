public class PitBull : Dog
{
  public string FavoriteToy { get; set; }

  public PitBull(string favoriteToy)
  {
    FavoriteToy = favoriteToy;
  }

  public void Play()
  {
    Console.WriteLine($"This Pitbull is now playing with {FavoriteToy} and won't let go");
  }
}