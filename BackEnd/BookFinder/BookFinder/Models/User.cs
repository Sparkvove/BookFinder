namespace BookFinder.Models
{
    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<Book>? BookList { get; set; }


        public User(int id, string name, List<Book>? bookList)
        {
            Id = id;
            Name = name;
            BookList = bookList;
        }
    }
}
