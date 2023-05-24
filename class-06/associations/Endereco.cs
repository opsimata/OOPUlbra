using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace associations
{
    public class Endereco
    {
        public int Id { get; set; }
        public string Logradouro { get; set; }

        public Pessoa Pessoa { get; private set; }

        public Endereco(int id, string logradouro)
        {
            this.Id = id;
            this.Logradouro = logradouro;
        }

        // Polimorfismo(Sobrecarga): o mesmo método/construtor porém com comportamentos diferentes.

        public Endereco(int id, string logradouro, Pessoa pessoa)
        {
            this.Id = id;
            this.Logradouro = logradouro;
            this.Pessoa = pessoa;
        }
    }
}