public class Teacher : Human
{
  public string TaughtSubject { get; set; }

  public Teacher(string name, bool likesCoffee, string taughtSubject)
  {
    Name = name;
    LikesCoffee = likesCoffee;
    TaughtSubject = taughtSubject;
  }

  public void Teach()
  {
    Console.WriteLine($"{Name} is teaching {TaughtSubject}");
  }
}
