using BookFinder.Models;

namespace BookFinder.DataProvider
{
    public static class BookDB
    {
        public static List<Book>? BookList;

        public static void PopulateBooks()
        {
            
            var books = new List<Book>();
            books.Add(new Book(1,"jeden", "Autor1", "desc1"));
            books.Add(new Book(2,"dwa", "Autor2", "desc2"));
            books.Add(new Book(3,"trzy", "Autor3", "desc3"));

            BookList = new List<Book>();
            BookList.AddRange(books);
        }
    }
}
