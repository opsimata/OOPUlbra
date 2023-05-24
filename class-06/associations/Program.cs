using associations;

namespace associations // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            City city = new City(11, "Torres");

            // Pessoa pessoa = new Pessoa(12, "Amanda", city); // Associação

            // pessoa.addEndereco(new Endereco(1, "Av. Silva Jardim, 227")); // Composição

            // foreach (var item in pessoa.Enderecos)
            // {
                
            // }

            PessoaFisica fisica = new PessoaFisica(1231, "Silva", city, "832942948302"); // Herança
        }
    }
}