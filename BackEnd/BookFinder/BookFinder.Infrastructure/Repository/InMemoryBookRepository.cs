using BookFinder.Core.Domain;
using BookFinder.Core.Domain.ValueObjects;
using BookFinder.Core.Repositories;
namespace BookFinder.Infrastructure.Repository
{
    public class InMemoryBookRepository : IBookRepository
    {
        private static ISet<Book> _books = new HashSet<Book>
        {
            new Book(Guid.NewGuid(),"The Hunger Games", Person.CreatePerson(Guid.NewGuid(), "Collins", "Suzanne", null), " In a post-apocalyptic North America, the ruling Capitol selects a boy and a girl from each of the twelve districts to fight to the death in the annual Hunger Games.", new List<string>{ "Young Adult", "Dystopian","Science Fiction"}, new List<string>{"Strong Female Lead", "Survival", "Action"}, 4, "https://m.media-amazon.com/images/I/414fBKKVniL._SY344_BO1,204,203,200_QL70_ML2_.jpg"),
            new Book(Guid.NewGuid(),"1984", Person.CreatePerson(Guid.NewGuid(),"Orwell","George ", null), "In a totalitarian society, a man named Winston Smith rebels against the oppressive regime and falls in love with a fellow rebel, leading to devastating consequences.",  new List<string>{"Classic", "Dystopian", "Science Fiction"}, new List<string>{"Political","Thought-Provoking","Dark"}, 5, "https://m.media-amazon.com/images/I/519zR2oIlmL._SY344_BO1,204,203,200_QL70_ML2_.jpg"),
            new Book(Guid.NewGuid(),"The Great Gatsby", Person.CreatePerson(Guid.NewGuid(), "Fitzgerald", "F. Scott", null), " Set in the Roaring Twenties, this novel tells the story of Jay Gatsby, a mysterious and wealthy man, and his obsession with the beautiful Daisy Buchanan.", new List<string>{ "Classic", "Romance", "Historical Fiction"}, new List<string>{ "Tragic", "Wealth", "Society"}, 4, "https://static1.winylownia.pl/pol_pm_The-Great-Gatsby-PLAKAT-51338_1.jpg"),
            new Book(Guid.NewGuid(),"The Hobbit", Person.CreatePerson(Guid.NewGuid(), "Tolkien", " J.R.R.", null), "Bilbo Baggins, a hobbit, is recruited by the wizard Gandalf to join a group of dwarves on a quest to reclaim their treasure from the dragon Smaug.", new List<string>{ "Fantasy", "Adventure"}, new List<string>{ "Epic", "Heroic Journey", "World-Building"}, 4, "https://m.media-amazon.com/images/I/41DfP7NpIIL._SY344_BO1,204,203,200_QL70_ML2_.jpg"),
            new Book(Guid.NewGuid(),"To Kill a Mockingbird", Person.CreatePerson(Guid.NewGuid(), "Lee", "Harper", null), "In a small town in Alabama during the 1930s, a black man is falsely accused of a crime, and a young girl named Scout Finch learns about racism and injustice.", new List<string>{ "Classic", "Historical Fiction"}, new List<string>{ "Coming of Age", "Racism", "Social Issues"}, 4, "https://bigimg.taniaksiazka.pl/images/popups/FB7/9780099466734.jpg"),
            new Book(Guid.NewGuid(),"The Catcher in the Rye", Person.CreatePerson(Guid.NewGuid(), "Salinger", "J.D.", null), " Holden Caulfield, a teenager struggling with his own depression and disillusionment with society, embarks on a journey through New York City.", new List<string>{ "Classic", "Coming of Age"}, new List<string>{ "Alienation", "Identity", "Rebellion"}, 4, "https://ecsmedia.pl/c/the-catcher-in-the-rye-b-iext128263231.jpg"),
        };
        public Book Find(string title)
        {
            return _books.Single(x => x.Title == title);
        }

        public Book Get(Guid guid)
        {
            return _books.Single(x => x.Id== guid);
        }

        public IEnumerable<Book> GetAll()
        {
            return _books;
        }
    }
}
