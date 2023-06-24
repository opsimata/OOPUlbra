using Domain.Entities;
using Domain.Interfaces;
using Microsoft.EntityFrameworkCore;

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
            return context.People.Include(x => x.City).ToList();
        }
        public Person GetById(int entityId)
        {
            return context.People.Include(x => x.City).SingleOrDefault(x => x.Id == entityId); // === Select All From *People* Where ID == Parsed ID.
        }
        public void Save(Person entity) //Create on DB
        {
            entity.City = context.Cities.Find(entity.City.Id);
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
            context.People.Update(entity);
            context.SaveChanges();
        }
    }
}