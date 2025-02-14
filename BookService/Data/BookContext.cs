
using Microsoft.EntityFrameworkCore;
using BookService.Models;

namespace BookService.Data
{
    public class BookContext : DbContext

    {
        public BookContext(DbContextOptions<BookContext> options) : base(options)
        { }
        public DbSet<Book> Books { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Book>().ToTable("Books"); 
        }
    }
}
