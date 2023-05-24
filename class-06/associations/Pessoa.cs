using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace associations
{
    public abstract class Pessoa
    {
        public int Id { get; set; }
        public string Nome { get; protected set; }
        public City City { get; set; }
        public List<Endereco> Enderecos { get; set; }

        public Pessoa(int id, string nome, City city)
        {
            this.Id = id;
            this.Nome = nome;
            this.City = city;
        }

        public void addEndereco(Endereco endereco)
        {
            this.Enderecos.Add(endereco);
        }
    }
}