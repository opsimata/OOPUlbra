namespace class_04
{
    public class BookRepository
    {
        public static List<Book> bookList = new List<Book>();

        public List<Book> GetAll()
        {
            return bookList;
        }
        public Book GetById(int id)
        {
            return bookList.Find(bk => bk.Id == id);
        }
        public List<Book> GetByContainName(string srch)
        {
            return bookList.FindAll(x => x.Title.Contains(srch));
        }
        public void Add(Book book)
        {
            bookList.Add(book);
        }
        public void Delete(Book book)
        {

        }
    }
}