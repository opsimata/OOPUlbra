using System;

namespace exercise02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var professor = new Teacher { Name = "Joao", Age = 40 }; // Construtor anônimo
            var aluno = new Student { Name = "Maria", Age = 20 }; // Construtor anônimo

            var escola = new School();

            escola.IntroducePerson(professor);
            escola.IntroducePerson(aluno);
        }
    }
}