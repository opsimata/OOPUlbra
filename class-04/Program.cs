using class_04;

internal class Program
{
    static void Main(string[] args)
    {
        Book book01 = new Book(1, "154789", "Lorem 1", 50.23);
        Book book02 = new Book(2, "145489", "Lorem 2 fa", 24.00);
        Book book03 = new Book(3, "123456", "Lorem 3", 100);
        Book book04 = new Book(4, "987654", "Lorem 4", 234.14);

        BookRepository repository = new BookRepository();

        repository.Add(book01);
        repository.Add(book02);
        repository.Add(book03);
        repository.Add(book04);

        BreakLine();

        foreach (var item in repository.GetAll())
        {
            Print($"ID: {item.Id}, Livro: {item.Title}, ISBN: {item.Isbn}, Preço: R${item.Price}.");
            BreakLine();
        }

        for (int i = 0; i < BookRepository.bookList.Count ; i++)
        {
            if (BookRepository.bookList[i].Id == 2)
            {
                Print("\nUsando For:\nLivro com Id 2: " + BookRepository.bookList[i].Title);
            }
        }

        BreakLine();

        foreach (var item in BookRepository.bookList)
        {
            if (item.Id == 2)
            {
                Print("\nUsando ForEach:\nLivro com Id 2: " + item.Title);
            }
        }

        BreakLine();

        Print("\nUsando Lambda Expression/Arrow Function:\nLivro com Id 4: " + BookRepository.bookList.Find(x => x.Id == 4).Title);

        BreakLine();
        BreakLine();

        Print("Press any key to close...");
        Input();


        void Print(string msg)
        {
            Console.Write(msg);
        }
        void BreakLine()
        {
            Console.Write("\n");
        }
        void Input()
        {
            Console.ReadLine();
        }
    }
}