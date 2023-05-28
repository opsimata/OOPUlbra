using Domain.Entities;
using Domain.Interfaces;

namespace Data.Repositories
{
    public class PersonRepository : IPersonRepository
    {
        private readonly DataContext context;

        public PersonRepository(DataContext context)
        {
            this.context = context;
        }

        public IList<Person> GetAll()
        {
            return context.People.ToList();
        }
        public Person GetById(int entityId)
        {
            return context.People.SingleOrDefault(x => x.Id == entityId); // === Select All From *People* Where ID == Parsed ID.
        }
        public void Save(Person entity) //Create on DB
        {
            context.Add(entity);
            context.SaveChanges();
        }
        public bool Delete(int entityId)
        {
            bool validator;
            var person = GetById(entityId);
            if (person.Id == entityId)
            {
                context.Remove(person);
                context.SaveChanges();
                validator = true;
                Console.WriteLine($"\n{person.Name} data was successfully deleted from the database!\n");

            }
            else
            {
                validator = false;
                Console.WriteLine("\nInvalid Operation!");
            }
            return validator;
        }
        public void Update(Person entity)
        {
            throw new NotImplementedException();
        }
    }
}