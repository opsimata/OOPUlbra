using class_02;

internal class Program
{
    private static void Main(string[] args)
    {
        Book bookDB = new Book(1, "9785523039058", "Banco de Dados", 50);

        Utilities.Print("\nDados do Livro: \n" + bookDB.Id + ", " + bookDB.Isbn + ", " + bookDB.Title + ", " + bookDB.Price);

        Utilities.BreakLine();
        Utilities.BreakLine();

        Utilities.Print("Digite algo: ");

        var input = Console.ReadLine();

        Utilities.BreakLine();

        Utilities.Print("Algo digitado: " + input);

        Utilities.BreakLine();
        Utilities.BreakLine();

        Utilities.Print("** Calculadora **\nOperações possíveis:\n| Soma: '+' | Subtração: '-' | Divisão: '/' | Multiplicação: '*' |\n\nInforme o cálculo desejado: ");
        string operation = Console.ReadLine();

        Utilities.BreakLine();

        Utilities.Print("Informe o primeiro número a ser calculado: ");
        double number1 = Convert.ToDouble(Console.ReadLine());

        Utilities.BreakLine();

        Utilities.Print("Informe o segundo número a ser calculado: ");
        double number2 = Convert.ToDouble(Console.ReadLine());

        Calculator Calc1 = new Calculator();

        var outcome = Calc1.Process(number1, number2, operation);

        Utilities.BreakLine();

        Utilities.Print("Resultado da operação: " + outcome);

        Utilities.BreakLine();
    }
}