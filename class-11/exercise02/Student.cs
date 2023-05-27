namespace exercise02
{
    public class Student : IPerson
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public void Speak()
        {
            Console.WriteLine($"\nOi, meu nome é {Name} e eu tenho {Age} anos.");
        }

        public void Study()
        {
            Console.WriteLine($"\n{Name} está aprendendo a matéria POO.");
        }
    }
}