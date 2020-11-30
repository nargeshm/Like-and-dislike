using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Demo_Dall7;

namespace Book_Home.Controllers
{
    public class BooksController : Controller
    {
        private readonly BookLibaryContext _context;


        public BooksController(BookLibaryContext context)
        {
            _context = context;
        }
        //or you can call your obj like this:

        //public BooksController()
        //{
        //    _context = new BookLibaryContext() ;
        //}

        // GET: Books
        //if you use this code in ctor you must add this code in ConfigureServices:
        // services.AddScoped<BookLibaryContext>();
        public async Task<IActionResult> Index()
        {
            return View(await _context.Books.OrderByDescending(a=>a.LikeCount).ToListAsync());
        }

        // GET: Books/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var book = await _context.Books
                .FirstOrDefaultAsync(m => m.BookId == id);
            if (book == null)
            {
                return NotFound();
            }

            return View(book);
        }

        // GET: Books/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Books/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("BookId,BookName,LikeCount,Abstract")] Book book)
        {
            if (ModelState.IsValid)
            {
                _context.Add(book);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(book);
        }

        // GET: Books/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var book = await _context.Books.FindAsync(id);
            if (book == null)
            {
                return NotFound();
            }
            return View(book);
        }

        // POST: Books/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("BookId,BookName,LikeCount,Abstract")] Book book)
        {
            if (id != book.BookId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(book);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!BookExists(book.BookId))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(book);
        }

        // GET: Books/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var book = await _context.Books
                .FirstOrDefaultAsync(m => m.BookId == id);
            if (book == null)
            {
                return NotFound();
            }

            return View(book);
        }

        // POST: Books/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var book = await _context.Books.FindAsync(id);
            _context.Books.Remove(book);

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool BookExists(int id)
        {
            return _context.Books.Any(e => e.BookId == id);
        }

        //like action:

        public  IActionResult LikeThis(int id)
        {
            Book art = _context.Books.Find(id);
            if (art !=null)
            {    
                art.LikeCount++;
                BooksLike like = new BooksLike
                {
                    LikeTime = DateTime.Now,
                    BookId=id,
                    IsLike = true
                };
           
                _context.Update(like);
                _context.SaveChanges();

            }
         return   RedirectToAction("Details",id);
         
        }
      

        //unlike action:
        public string UnlikeThis(int id)
        {
            Book art = _context.Books.Find( id);
            if (art !=null )
            {
              
                BooksLike like = _context.likes.FirstOrDefault(a=>a.BookId==id );
                art.LikeCount--;
                _context.likes.Remove(like);
                _context.SaveChanges();

            }
            return art.LikeCount.ToString();
        }
    }
}
