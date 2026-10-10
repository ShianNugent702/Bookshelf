using Bookshelf.Models;
using Microsoft.AspNetCore.Mvc;

namespace Bookshelf.Controllers
{
    public class BookController : Controller
    {
        private static List<Book> _books = new List<Book>
        {
            new Book { Id = 1, Title = "The Hobbit", Author = "J.R.R. Tolkien", Pages = 310, IsRead = true },
            new Book { Id = 2, Title = "1984", Author = "George Orwell", Pages = 328, IsRead = false },
            new Book { Id = 3, Title = "Dune", Author = "Frank Herbert", Pages = 412, IsRead = false },
            new Book { Id = 4, Title = "The Great Gatsby", Author = "F. Scott Fitzgerald", Pages = 180, IsRead = true },
            new Book { Id = 5, Title = "To Kill a Mockingbird", Author = "Harper Lee", Pages = 281, IsRead = false },
            new Book { Id = 6, Title = "The Catcher in the Rye", Author = "J.D. Salinger", Pages = 234, IsRead = false }
        };

        public IActionResult Index()
        {
            return View();
        }
        [HttpGet("book/{id:int}")]
        public IActionResult Details(int id)
        {
            var book = _books.FirstOrDefault(b => b.Id == id);
            if (book == null) return NotFound();
            return View(book);
        }
        [HttpPost]
        public IActionResult MarkAsRead(int id)
        {
            var book = _books.FirstOrDefault(b => b.Id == id);
            if (book != null)
            {
                book.IsRead = true;
                TempData["Message"] = $"You have read {book.Title}!";
            }
            return RedirectToAction("Index");
        }
    }
}