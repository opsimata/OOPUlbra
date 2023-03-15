namespace class_02
{
    public class Person
    {
        public int Age { get; set; }

        public string Name { get; set; }

        public Person(int age, string name)
        {
            this.Age = age;
            this.Name = name;
        }
    }
}