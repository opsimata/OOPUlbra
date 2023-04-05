namespace exercise_01
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Dog dog = new Dog();
            dog.Name = "Kannemann";
            Cat cat = new Cat();
            cat.Name = "Geromel";

            Console.WriteLine("\nCão " + dog.Name + ":");
            dog.Speak();
            System.Console.WriteLine("\n");
            Console.WriteLine("Gato " + cat.Name + ":");
            cat.Speak();

            Console.Write("\nPress any key to close...");
            Console.ReadLine();

        }
    }
}