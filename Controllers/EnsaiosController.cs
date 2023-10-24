using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using EnsaioApp.Data;
using EnsaioApp.Models;

namespace EnsaioApp.Controllers
{
    public class EnsaiosController : Controller
    {
        private readonly ApplicationDbContext _context;

        public EnsaiosController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Ensaios
        public async Task<IActionResult> Index()
        {
            var applicationDbContext = _context.Ensaio.Include(e => e.Cliente);
            return View(await applicationDbContext.ToListAsync());
        }

        // GET: Ensaios/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.Ensaio == null)
            {
                return NotFound();
            }

            var ensaio = await _context.Ensaio
                .Include(e => e.Cliente)
                .FirstOrDefaultAsync(m => m.EnsaioId == id);
            if (ensaio == null)
            {
                return NotFound();
            }

            return View(ensaio);
        }

        // GET: Ensaios/Create
        public IActionResult Create()
        {
            ViewData["ClienteId"] = new SelectList(_context.Cliente, "ClienteId", "ClienteId");
            return View();
        }

        // POST: Ensaios/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("EnsaioId,ClienteId")] Ensaio ensaio)
        {
            if (ModelState.IsValid)
            {
                _context.Add(ensaio);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["ClienteId"] = new SelectList(_context.Cliente, "ClienteId", "ClienteId", ensaio.ClienteId);
            return View(ensaio);
        }

        // GET: Ensaios/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.Ensaio == null)
            {
                return NotFound();
            }

            var ensaio = await _context.Ensaio.FindAsync(id);
            if (ensaio == null)
            {
                return NotFound();
            }
            ViewData["ClienteId"] = new SelectList(_context.Cliente, "ClienteId", "ClienteId", ensaio.ClienteId);
            return View(ensaio);
        }

        // POST: Ensaios/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("EnsaioId,ClienteId")] Ensaio ensaio)
        {
            if (id != ensaio.EnsaioId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(ensaio);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!EnsaioExists(ensaio.EnsaioId))
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
            ViewData["ClienteId"] = new SelectList(_context.Cliente, "ClienteId", "ClienteId", ensaio.ClienteId);
            return View(ensaio);
        }

        // GET: Ensaios/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.Ensaio == null)
            {
                return NotFound();
            }

            var ensaio = await _context.Ensaio
                .Include(e => e.Cliente)
                .FirstOrDefaultAsync(m => m.EnsaioId == id);
            if (ensaio == null)
            {
                return NotFound();
            }

            return View(ensaio);
        }

        // POST: Ensaios/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.Ensaio == null)
            {
                return Problem("Entity set 'ApplicationDbContext.Ensaio'  is null.");
            }
            var ensaio = await _context.Ensaio.FindAsync(id);
            if (ensaio != null)
            {
                _context.Ensaio.Remove(ensaio);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool EnsaioExists(int id)
        {
          return (_context.Ensaio?.Any(e => e.EnsaioId == id)).GetValueOrDefault();
        }
    }
}
