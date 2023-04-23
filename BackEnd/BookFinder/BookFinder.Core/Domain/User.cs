namespace BookFinder.Core.Domain
{
    public class User
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public List<Book> BookList { get; private set; } = new();


        public User(string name, List<Book> bookList)
        {
            Name = name;
            BookList = bookList;
        }

        public void AddToBookList(Book book)
        {
            BookList.Add(book);
        }
    }
}
