using class_02;

internal class Program
{
    private static void Main(string[] args)
    {
        Book bookDB = new Book(1, "9785523039058", "Banco de Dados", 50);

        Print("\nDados do Livro: \n" + bookDB.Id + ", " + bookDB.Isbn + ", " + bookDB.Title + ", " + bookDB.Price);

    var Scan = Console.ReadLine();

    Print(Scan);

    void Print(string msg){
        Console.WriteLine(msg);
    }




    }
}