using Microsoft.AspNetCore.Mvc;

namespace Bookshelf.Models
{
    public class Book : Controller
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public int Pages { get; set; }
        public bool IsRead { get; set; }
        public IActionResult Index()
        {
            return View();
        }
    }
}
