﻿namespace BookFinder.Domain
{
    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<Book> BookList { get; private set; } = new();


        public User(int id, string name, List<Book> bookList)
        {
            Id = id;
            Name = name;
            BookList = bookList;
        }

        public void AddToBookList(Book book)
        {
            BookList.Add(book);
        }
    }
}
