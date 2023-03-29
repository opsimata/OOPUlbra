namespace _01_PeopleListCRUD
{
    public class Person
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int Phone { get; set; }
        public Person(int id, string name, int phone)
        {

            this.ID = id;
            this.Name = name;
            this.Phone = phone;

        }
    }
}