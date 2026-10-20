using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace Bookshelf.Data
{
    public class BookshelfContextFactory : IDesignTimeDbContextFactory<BookshelfContext>
    {
        public BookshelfContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<BookshelfContext>();
            // You can use a dummy connection string here; it's only used for creating the migration
            optionsBuilder.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=Bookshelf;Trusted_Connection=True;");

            return new BookshelfContext(optionsBuilder.Options);
        }
    }
}
