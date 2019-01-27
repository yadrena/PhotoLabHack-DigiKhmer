using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using WebApplication3.Models;

namespace WebApplication3.Controllers
{
    public class MucksController : Controller
    {
        private readonly MvcMovieContext _context;

        public MucksController(MvcMovieContext context)
        {
            _context = context;
        }

        // GET: Mucks
        public async Task<IActionResult> Index()
        {
            return View(await _context.Muck.ToListAsync());
        }

        // GET: Mucks/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var muck = await _context.Muck
                .FirstOrDefaultAsync(m => m.Id == id);
            if (muck == null)
            {
                return NotFound();
            }

            return View(muck);
        }

        // GET: Mucks/Details/5
        public async Task<IActionResult> Details2(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var muck = await _context.Muck
                .FirstOrDefaultAsync(m => m.Id == id);
            if (muck == null)
            {
                return NotFound();
            }

            return View(muck);
        }

        // GET: Mucks/Details/5
        public async Task<IActionResult> Details3(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var muck = await _context.Muck
                .FirstOrDefaultAsync(m => m.Id == id);
            if (muck == null)
            {
                return NotFound();
            }

            return View(muck);
        }

        // GET: Mucks/Details/5
        public async Task<IActionResult> Quiz(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var muck = await _context.Muck
                .FirstOrDefaultAsync(m => m.Id == id);
            if (muck == null)
            {
                return NotFound();
            }

            return View(muck);
        }

        // GET: Mucks/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Mucks/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,AuthorEmail,Image,UploadedImageURL,AppliedTemplate,ConvertedImageURL,BluredImageURL")] Muck muck)
        {
            if (ModelState.IsValid)
            {
                _context.Add(muck);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(muck);
        }

        // GET: Mucks/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var muck = await _context.Muck.FindAsync(id);
            if (muck == null)
            {
                return NotFound();
            }
            return View(muck);
        }

        // POST: Mucks/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,AuthorEmail,Image,UploadedImageURL,AppliedTemplate,ConvertedImageURL,BluredImageURL")] Muck muck)
        {
            if (id != muck.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(muck);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!MuckExists(muck.Id))
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
            return View(muck);
        }

        // GET: Mucks/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var muck = await _context.Muck
                .FirstOrDefaultAsync(m => m.Id == id);
            if (muck == null)
            {
                return NotFound();
            }

            return View(muck);
        }

        // POST: Mucks/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var muck = await _context.Muck.FindAsync(id);
            _context.Muck.Remove(muck);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool MuckExists(int id)
        {
            return _context.Muck.Any(e => e.Id == id);
        }
    }
}
