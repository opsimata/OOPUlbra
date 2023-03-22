using class_02;

internal class Program
{
    private static void Main(string[] args)
    {
        // Book bookDB = new Book(1, "9785523039058", "Banco de Dados", 50);

        // Utilities.Print("\nDados do Livro: \n" + bookDB.Id + ", " + bookDB.Isbn + ", " + bookDB.Title + ", " + bookDB.Price);

        // Utilities.BreakLine();
        // Utilities.BreakLine();

        // Utilities.Print("Digite algo: ");

        // var input = Console.ReadLine();

        // Utilities.BreakLine();

        // Utilities.Print("Algo digitado: " + input);

        // Utilities.BreakLine();
        // Utilities.BreakLine();

        // // Exercício 1
        // Utilities.Print("** Calculadora **\nOperações possíveis:\n| Soma: '+' | Subtração: '-' | Divisão: '/' | Multiplicação: '*' |\n\nInforme o cálculo desejado: ");
        // string operation = Console.ReadLine();

        // Utilities.BreakLine();

        // Utilities.Print("Informe o primeiro número a ser calculado: ");
        // double number1 = Convert.ToDouble(Console.ReadLine());

        // Utilities.BreakLine();

        // Utilities.Print("Informe o segundo número a ser calculado: ");
        // double number2 = Convert.ToDouble(Console.ReadLine());

        // Calculator Calc_01 = new Calculator();

        // var outcome = Calc_01.Process(number1, number2, operation);

        // Utilities.BreakLine();

        // Utilities.Print("Resultado da operação: " + outcome);

        // Utilities.BreakLine();
        // Utilities.BreakLine();

        // //  Exercício 2
        // Person Person_01 = new Person(22, "Ava");
        // Utilities.Print("Nome: " + Person_01.Name + "\nIdade: " + Person_01.Age);

        // Utilities.BreakLine();
        // Utilities.BreakLine();

        // Exercício 3
        Utilities.Print("Informe o saldo da conta: ");
        double balance = Convert.ToDouble(Console.ReadLine());

        Utilities.Print("Informe o valor de deposito: ");
        double dpstValue = Convert.ToDouble(Console.ReadLine());

        Utilities.Print("Informe o valor de saque: ");
        double wthdrwValue = Convert.ToDouble(Console.ReadLine());

        BankAccount Account_01 = new BankAccount(balance, dpstValue, wthdrwValue);

        Utilities.BreakLine();

        Utilities.Print("Saldo: " + Account_01.Balance);


    }
}