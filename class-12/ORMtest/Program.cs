using Data;
using Data.Repositories;
using Domain.Entities;

#region
// var db = new DataContext(); // *old*
// Console.WriteLine($"\nPath do bando de dados: {db.DbPath}."); // Printa o caminho do banco de dados.
#endregion

var db = new DataContext();
var personRepository = new PersonRepository(db);
var loop = 1;

ListPeople();

// Adicionando pessoas a base de dados "People"
#region
Console.WriteLine("Add a new person on the database?\nType '1' for yes.\nType '2' for no.");
Console.Write("Type your choice: ");
var choice = Convert.ToInt32(Console.ReadLine());

if (choice == 1)
{
    var person = new Person();
    Console.Write("\nType the person's ID: ");
    person.Id = Convert.ToInt32(Console.ReadLine());
    Console.Write("Type the person's Name: ");
    person.Name = Console.ReadLine();
    Console.Write("Type the person's Phone number: ");
    person.PhoneNumber = Console.ReadLine();
    personRepository.Save(person);
    Console.WriteLine();
}
else
{
    Console.WriteLine();
}
#endregion

// Comentário
#region
// var person = new Person() // Inserindo pessoa no bando de dados via repositorio person diretamente
// {
//     Id = 1,
//     Name = "Douglas Katee Batts",
//     PhoneNumber = "11977762325"
// };
// personRepository.Save(person); // Salva pessoa no banco de dados via repositorio person
#endregion

// Procurando pessoas na base de dados "People"
#region

Console.WriteLine("Search a person on the database?\nType '1' for yes.\nType '2' for no.");
Console.Write("Type your choice: ");
choice = Convert.ToInt32(Console.ReadLine());
if (choice == 1)
{
    do
    {
        Console.Write("\nType the ID of the person you're searching for: ");
        int searchedID = Convert.ToInt32(Console.ReadLine());
        var personFindById = personRepository.GetById(searchedID);
        Console.WriteLine();
        Console.WriteLine("Requested data:");
        Console.WriteLine($"ID: {personFindById.Id}\nName: {personFindById.Name}\nPhone Number: {personFindById.PhoneNumber}");
        Console.WriteLine("\nSearch another person on the database?\nType '1' for yes.\nType '2' for no.");
        Console.Write("Type your choice: ");
        loop = Convert.ToInt32(Console.ReadLine());
        if (loop == 2)
        {
            Console.WriteLine();
        }
    } while (loop == 1);
}
else
{
    Console.WriteLine();
}
#endregion

// Deletando pessoas da base de dados "People"
#region
Console.WriteLine("Delete a person from the database?\nType '1' for yes.\nType '2' for no.");
Console.Write("Type your choice: ");
choice = Convert.ToInt32(Console.ReadLine());
if (choice == 1)
{
    Console.Write("\nType the ID of the person registration to be deleted: ");
    int deletedID = Convert.ToInt32(Console.ReadLine());
    personRepository.Delete(deletedID);
}
else
{
    Console.WriteLine();
}
#endregion

// Menu para printar no console a base de dados "People"
#region
Console.WriteLine("Show people table again?\nType '1' for yes.\nType '2' for no.");
Console.Write("Type your choice: ");
choice = Convert.ToInt32(Console.ReadLine());

if (choice == 1)
{
    ListPeople();
}
else
{
    Console.WriteLine("\nGoodbye!\n");
}
#endregion

Console.WriteLine("Press any key to close...");
Console.Read();

// Métodos utilitários
#region
void ListPeople()
{
    var people = personRepository.GetAll(); // Get em todas as pessoas salvas no banco
    Console.WriteLine("\nPeople list:");
    foreach (var item in people) // Lista as pessoas salvas no banco em print na tela
    {
        Console.WriteLine($"ID: {item.Id} | Name: {item.Name} | Phone Number: {item.PhoneNumber}");
    }
    Console.Write("\n");
}
#endregion

// Comentário
#region 
// db.Add(person); // Adiciona objeto person para db. *old*
// db.SaveChanges(); // Salva alterações no objeto estância de DataContext "db". *old*

// var prod = new Product() // Inserindo produto no bando de dados via 
// {
//     Id = 1354,
//     Description = "Water Bottle, 500ml."
// };
// db.Add(prod);
// db.SaveChanges();
#endregion