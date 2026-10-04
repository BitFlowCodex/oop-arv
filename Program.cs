namespace oop_arv
{
    class Program
    {
        static void Main(string[] args)
        {
            Parrot parrot = new Parrot(spokenMessage: "Good morning");
            parrot.MakeSound();
            parrot.Fly();
            parrot.Speak();

            Console.WriteLine("\n");

            Penguin penguin = new Penguin(sliding: true);
            penguin.MakeSound();
            penguin.Fly();
            penguin.Slide();

            Console.WriteLine("\n");

            Angus angus = new Angus();
            angus.MakeSound();
            angus.Horns();
            angus.HasBlackCoat();

            Console.WriteLine("\n");

            Highland highland = new Highland(hairShake: false);
            highland.MakeSound();
            highland.Horns();
            highland.ShakeHair();

            Console.WriteLine("\n");

            GoldenRetriver goldenRetriver = new GoldenRetriver(lovesWater: true);
            goldenRetriver.MakeSound();
            goldenRetriver.Swim();

            Console.WriteLine("\n");

            PitBull pitBull = new PitBull(favoriteToy: "teddy");
            pitBull.MakeSound();
            pitBull.Play();

            Console.WriteLine("\n");

            Teacher teacher = new Teacher(name: "James Bond", likesCoffee: true, taughtSubject: "Programming");
            teacher.MakeSound();
            teacher.Teach();
            teacher.DrinkCoffee();

            Console.WriteLine("\n");

            Student student = new Student(name: "Jack Morales", likesCoffee: false, favoriteSubject: "Programming");
            student.MakeSound();
            student.Study();
            student.DrinkCoffee();

            Console.WriteLine("\n");
        }
    }
}