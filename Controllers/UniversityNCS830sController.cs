using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using NguyenCaoSang830.Models;
using NguyenCaoSang830.Data;

namespace NguyenCaoSang830.Controllers
{
    public class UniversityNCS830sController : Controller
    {
        private readonly ApplicationDBContext _context;

        public UniversityNCS830sController(ApplicationDBContext context)
        {
            _context = context;
        }

        // GET: UniversityNCS830s
        public async Task<IActionResult> Index()
        {
            return View(await _context.UniversityNCS830.ToListAsync());
        }

        // GET: UniversityNCS830s/Details/5
        public async Task<IActionResult> Details(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var universityNCS830 = await _context.UniversityNCS830
                .FirstOrDefaultAsync(m => m.UniversityId == id);
            if (universityNCS830 == null)
            {
                return NotFound();
            }

            return View(universityNCS830);
        }

        // GET: UniversityNCS830s/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: UniversityNCS830s/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("UniversityId,UniversityName")] UniversityNCS830 universityNCS830)
        {
            if (ModelState.IsValid)
            {
                _context.Add(universityNCS830);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(universityNCS830);
        }

        // GET: UniversityNCS830s/Edit/5
        public async Task<IActionResult> Edit(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var universityNCS830 = await _context.UniversityNCS830.FindAsync(id);
            if (universityNCS830 == null)
            {
                return NotFound();
            }
            return View(universityNCS830);
        }

        // POST: UniversityNCS830s/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string id, [Bind("UniversityId,UniversityName")] UniversityNCS830 universityNCS830)
        {
            if (id != universityNCS830.UniversityId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(universityNCS830);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!UniversityNCS830Exists(universityNCS830.UniversityId))
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
            return View(universityNCS830);
        }

        // GET: UniversityNCS830s/Delete/5
        public async Task<IActionResult> Delete(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var universityNCS830 = await _context.UniversityNCS830
                .FirstOrDefaultAsync(m => m.UniversityId == id);
            if (universityNCS830 == null)
            {
                return NotFound();
            }

            return View(universityNCS830);
        }

        // POST: UniversityNCS830s/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(string id)
        {
            var universityNCS830 = await _context.UniversityNCS830.FindAsync(id);
            _context.UniversityNCS830.Remove(universityNCS830);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool UniversityNCS830Exists(string id)
        {
            return _context.UniversityNCS830.Any(e => e.UniversityId == id);
        }
    }
}
