﻿using BookFinder.Core.Domain;
using BookFinder.Core.Domain.ValueObjects;
using BookFinder.Core.Repositories;

namespace BookFinder.Infrastructure.Services
{
    public class BookService : IBookService
    {
        private readonly IBookRepository _bookRepository;

        public BookService(IBookRepository bookRepository)
        {
            _bookRepository = bookRepository;
        }

        public IEnumerable<Book> GetAll()
        {
            var books = _bookRepository.GetAll();
            if(books is null)
            {
                throw new Exception("There is no books in dataProvider");
            }
            return books;
        }

        public Book GetByGuid(Guid guid)
        {
            var book = _bookRepository.Get(guid);
            return book;
        }

        public Book Find(string? title, string? description, Person? author)
        {
            var books = _bookRepository.GetAll();
            return books.SingleOrDefault(x => x.Title == title || x.Description == description || x.Author == author);
        }

 
        public IEnumerable<Book> GetRecommended()
        {
            throw new NotImplementedException();
        }

        public Book GetByTitle(string title)
        {
            var book = _bookRepository.Find(title);
            return book;
        }
    }
}
