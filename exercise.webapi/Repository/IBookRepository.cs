﻿using exercise.webapi.Models;

namespace exercise.webapi.Repository
{
    public interface IBookRepository
    {
        Task<Book> AddBook(Book book);
        public Task<IEnumerable<Book>> GetAllBooks();
        Task<Book?> GetBookById(int id);
        void DeleteBook(Book book);
        Task<Book> UpdateBook(Book book);
    }
}
