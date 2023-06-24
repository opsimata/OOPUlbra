namespace Domain.Entities
{
    public class Person
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string PhoneNumber { get; set; }
        public City City { get; set; } // Agora a pessoa pertencera a uma cidade, 
                                       // pois um atributo do tipo City(Classe) foi adicionado na classe Person
    }
}