using BookFinder.Core.Domain;
using BookFinder.Core.Repositories;
using System.Text.Json;

namespace BookFinder.Infrastructure.Repository
{
    public class FileUserRepository : IUserRepository
    {
        private readonly string _filename = "Users.json";
        public void Add(User user)
        {
            throw new NotImplementedException();
        }

        public void AddBook(User user, Book book)
        {
            var users = Load();
            var newUsers = new List<User>();
            var u = users.First(x => x.Name == user.Name);
            u.BookList.Add(book);

            foreach (var u2 in users)
            {
                if (u2.Name == user.Name)
                {
                    newUsers.Add(u);
                } else
                {
                    newUsers.Add(u2);
                }
                
            }

            Save(newUsers);

        }

        public User Get(Guid Id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<User> GetAll()
        {
            throw new NotImplementedException();
        }

        public User GetByUsername(string username)
        {
            var users = Load();
            return users.First(x => x.Name == username);
        }

        private IEnumerable<User> Load()
        {
            var users = new List<User>();
            using (StreamReader r = new StreamReader(_filename))
            {
                string json = r.ReadToEnd();
                users = JsonSerializer.Deserialize<List<User>>(json);
            }

            return users;
        }

        private void Save(IEnumerable<User> users)
        {
            string json = JsonSerializer.Serialize(users);
            File.WriteAllText(_filename, json);
            
        }
    }
}
