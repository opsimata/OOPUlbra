namespace exercise02
{
    public class Teacher : IPerson
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public void Speak()
        {
            Console.WriteLine($"\nOlá, eu sou o professor {Name} e tenho {Age} anos.");
        }

        public void Teach()
        {
            Console.WriteLine($"\n{Name} está ensinando a matéria POO.");
        }
    }
}