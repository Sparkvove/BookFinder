using BookFinder.Domain;



public static class DataProvider
    {
        public static List<Book> BookList = new();
        public static List<User> UserList = new();

        public static void PrepareData()
        {
            PopulateBooks();
            PopulateUsersWithEmptyBookList();
        }

        private static void PopulateBooks()
        {
            
            var books = new List<Book>();
            books.Add(new Book(1,"jeden", "Autor1", "desc1"));
            books.Add(new Book(2,"dwa", "Autor2", "desc2"));
            books.Add(new Book(3,"trzy", "Autor3", "desc3"));

            BookList.AddRange(books);
        }

        private static void PopulateUsersWithEmptyBookList()
        {
            var users = new List<User>();
            users.Add(new User(1, "Spark", null));
            users.Add(new User(2, "Shiro", null));

            UserList.AddRange(users);
        }

   
    }

