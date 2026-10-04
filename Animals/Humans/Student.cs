public class Student : Human
{
  public string FavoriteSubject { get; set; }

  public Student(string name, bool likesCoffee, string favoriteSubject)
  {
    Name = name;
    LikesCoffee = likesCoffee;
    FavoriteSubject = favoriteSubject;
  }

  public void Study()
  {
    Console.WriteLine($"{Name} is studying {FavoriteSubject}");
  }
}