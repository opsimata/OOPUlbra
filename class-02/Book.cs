namespace class_02
{
    public class Book
    {
        public int Id { get; private set; }

        public string Isbn { get; private set; }

        public string Title { get; private set; }

        public double Price { get; set; }

        public Book(int id, string isbn, string title, double price)
        {

            this.Id = id;
            this.Isbn = isbn;
            this.Title = title;
            this.Price = price;

        }
    }
}