using Microsoft.EntityFrameworkCore;
using Bookshelf.Models;
namespace Bookshelf.Data
{
    public class BookshelfContext: DbContext
    {
        public BookshelfContext(DbContextOptions<BookshelfContext> options): base(options) { }
        public DbSet<Book> Books {  get; set; }
    }
}
