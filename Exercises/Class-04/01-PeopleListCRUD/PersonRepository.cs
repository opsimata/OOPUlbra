namespace _01_PeopleListCRUD
{
    public class PersonRepository
    {
        public static List<Person> peopleList = new List<Person>();

        //Adding Person Object to the object list
        public void CreatePerson()
        {
            Console.Write("\nEnter person ID: ");
            int id = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter person name: " );
            string name = Console.ReadLine();

            Console.Write("Enter person phone: ");
            int phone = Convert.ToInt32(Console.ReadLine());

            Person person01 = new Person(id, name, phone);

            peopleList.Add(person01);

            Console.WriteLine("\nPerson added successfully!!!");
        }

        public void ReadPerson()
        {
            Console.Write("\nEnter person ID: ");
            int id = Convert.ToInt32(Console.ReadLine());

            Person person01 = peopleList.Find(e => e.ID == id);

            if (person01 != null)
            {
                Console.WriteLine("\nPerson ID: " + person01.ID);
                Console.WriteLine("Person name: " + person01.Name);
                Console.WriteLine("Person age: " + person01.Phone);
            }
            else
            {
                Console.WriteLine("\nPerson data not found!!!");
            }
        }

        public void UpdatePerson()
        {
            Console.Write("\nEnter person ID: ");
            int id = Convert.ToInt32(Console.ReadLine());

            Person person01 = peopleList.Find(e => e.ID == id);

            if (person01 != null)
            {
                Console.Write("\nEnter person name: ");
                person01.Name = Console.ReadLine();

                Console.Write("\nEnter person phone number: ");
                person01.Phone = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("\nPerson data updated successfully!!");
            }
            else
            {
                Console.WriteLine("\nPerson data not found!!!");
            }
        }

        public void DeletePerson()
        {
            Console.Write("\nEnter person ID: ");
            int id = Convert.ToInt32(Console.ReadLine());

            Person person01 = peopleList.Find(e => e.ID == id);

            if (person01 != null)
            {
                peopleList.Remove(person01);

                Console.WriteLine("\nPerson data deleted successfully!!!");
            }
            else
            {
                Console.WriteLine("\nPerson data not found!!!");
            }
        }
    }
}