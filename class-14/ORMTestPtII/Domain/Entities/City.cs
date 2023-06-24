using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class City
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<Person> People { get; set; } // Aqui uma lista de pessoas(People) do tipo "Person" foi adicionada
                                                 // a classe "City", fazendo possível adicionar multiplas pessoas a mesma cidade.
    }
}