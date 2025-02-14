using System.Security.Cryptography.X509Certificates;
using BookService.Models;
using BookService.Repositories;

namespace BookService.Services
{
    public class BookService : IBookService
    {
        private readonly IBookRepository _repository;

        public BookService(IBookRepository repository)
        {
            _repository = repository;
        }

        public async Task<IEnumerable<Book>> GetAllBooksAsync()
        {
            return await _repository.GetAllAsync();

            public async Task<Book> GetBookByIdAsync(int id)
            {
                return await _repository.GetByIdAsync(id);
            }

            public async Task AddBookAsync(Book book)
            {
                await _repository.AddAsync(book);

            }
            
            public async Task DeleteBookAsync(int id)
            {
                await _repository.DeleteAsync(id);
            }

        }
    }
