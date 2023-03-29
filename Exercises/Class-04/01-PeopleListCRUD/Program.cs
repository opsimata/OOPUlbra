using _01_PeopleListCRUD;
internal class Program
{
    static void Main(string[] args)
    {

        bool keepGoing = true;

        while (keepGoing == true)
        {
            Console.WriteLine("\nSelect an operation:");
            Console.WriteLine("1. Create person");
            Console.WriteLine("2. Read person");
            Console.WriteLine("3. Update person");
            Console.WriteLine("4. Delete person");
            Console.WriteLine("5. Exit");
            Console.Write("\nType your choise: ");

            int choice = Convert.ToInt32(Console.ReadLine());

            PersonRepository repository = new PersonRepository();

            switch (choice)
            {
                case 1:
                    repository.CreatePerson();
                    break;
                case 2:
                    repository.ReadPerson();
                    break;
                case 3:
                    repository.UpdatePerson();
                    break;
                case 4:
                    repository.DeletePerson();
                    break;
                case 5:
                    Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("Invalid choice");
                    break;
            }

            Console.WriteLine("\nDo you want to make another operation?");
            Console.WriteLine("1. for YES.");
            Console.WriteLine("2. for NO.");
            Console.Write("Type your choise: ");

            string oprt = Console.ReadLine();

            if (oprt == "1")
            {
                keepGoing = true;
            }
            else if (oprt == "2")
            {
                Console.WriteLine("\nGoodbye!!!");
                keepGoing = false;
            }
            else
            {
                while (oprt != "1" && oprt != "2")
                {
                    Console.WriteLine("\nInvalid option!\nPlease type a valid option!!");
                    Console.WriteLine("\nDo you want to make another operation?");
                    Console.WriteLine("1. for YES.");
                    Console.WriteLine("2. for NO.");
                    Console.Write("Type your choise: ");

                    oprt = Console.ReadLine();
                }
            }
        }
    }
}
