using Microsoft.AspNetCore.Mvc;
using WebApplication2lab2.Models;
using WebApplication2lab2.Models;

namespace WebApplication2lab2.Controllers
{
    public class BookController : Controller
    {
        public static Book[] books = new Book[10];
        public static int count = 0;

        public IActionResult Details()
        {
            if (count == 0)
                return RedirectToAction("Create");

            return View(books[count - 1]);
        }

        public IActionResult Create()
        {
            return View(new Book { ArrivalDate = DateTime.Now });
        }

        [HttpPost]
        public IActionResult Create(Book book)
        {
            if (ModelState.IsValid)
            {
                book.Id = count + 1;
                books[count] = book;
                count++;
                return RedirectToAction("AllBooks");
            }
            return View(book);
        }

        public IActionResult Edit(int id)
        {
            Book book = books[id - 1];
            return View(book);
        }

        [HttpPost]
        public IActionResult Edit(Book book)
        {
            if (ModelState.IsValid)
            {
                books[book.Id - 1] = book;
                return RedirectToAction("AllBooks");
            }
            return View(book);
        }

        public IActionResult AllBooks()
        {
            ViewData["UseExternalHelper"] = true;
            return View(books);
        }
    }
}