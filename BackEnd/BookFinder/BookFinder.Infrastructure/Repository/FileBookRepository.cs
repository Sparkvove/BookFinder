using BookFinder.Core.Domain;
using BookFinder.Core.Repositories;
using System.Text.Json;

namespace BookFinder.Infrastructure.Repository
{
    public class FileBookRepository : IBookRepository
    {
        public Book Find(string title)
        {
            var books = Load();
            return books.First(x => x.Title == title);
        }

        public Book Get(Guid guid)
        {
            var books = Load();
            return books.First(x => x.Id == guid);
        }

        public IEnumerable<Book> GetAll()
        {
            var books = Load();
            return books;
        }

        private IEnumerable<Book> Load()
        {
            var books = new List<Book>();
            using (StreamReader r = new StreamReader("Books.json"))
            {
                string json = r.ReadToEnd();
                books = JsonSerializer.Deserialize<List<Book>>(json);
            }

            return books;
        }
    }
}
