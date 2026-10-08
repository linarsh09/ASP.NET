using AspNetCoreMVC.Data;
using AspNetCoreMVC.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace AspNetCoreMVC.Controllers
{
    public class HomeController : Controller
    {
        private readonly LibraryDbCopyContext _context;
        public HomeController(LibraryDbCopyContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            var booksList = _context.Books.ToList();

            return View(booksList);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
