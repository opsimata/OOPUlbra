using class_02;

internal class Program
{
    private static void Main(string[] args)
    {
        Book bookDB = new Book(1, "9785523039058", "Banco de Dados", 50);

        Utilities.Print("\nDados do Livro: \n" + bookDB.Id + ", " + bookDB.Isbn + ", " + bookDB.Title + ", " + bookDB.Price);

        Utilities.BreakLine();

        Utilities.Print("Digite algo: ");

        Utilities.Scan();

        Utilities.BreakLine();

        // Utilities.Print("Algo digitado: ");

        Utilities.Print("informe o calculo desejado:");

    }
}