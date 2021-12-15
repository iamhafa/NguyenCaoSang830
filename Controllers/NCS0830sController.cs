using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using NguyenCaoSang830.Data;
using NguyenCaoSang830.Models;

namespace NguyenCaoSang830.Controllers
{
    public class NCS0830sController : Controller
    {
        private readonly ApplicationDBContext _context;

        public NCS0830sController(ApplicationDBContext context)
        {
            _context = context;
        }

        // GET: NCS0830s
        public async Task<IActionResult> Index(string strInput)
        {
            var ncs = from n in _context.NCS0830s
                        select n;

            if(!String.IsNullOrEmpty(strInput))
            {
                ncs = ncs.Where(s => s.NCSName.ToUpper().Contains(strInput));
            }
            return View(await _context.NCS0830s.ToListAsync());
        }


        // GET: NCS0830s/Details/5
        public async Task<IActionResult> Details(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var nCS0830 = await _context.NCS0830s
                .FirstOrDefaultAsync(m => m.NCSId == id);
            if (nCS0830 == null)
            {
                return NotFound();
            }

            return View(nCS0830);
        }

        // GET: NCS0830s/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: NCS0830s/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("NCSId,NCSName,NCSGender")] NCS0830 nCS0830)
        {
            if (ModelState.IsValid)
            {
                _context.Add(nCS0830);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(nCS0830);
        }

        // GET: NCS0830s/Edit/5
        public async Task<IActionResult> Edit(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var nCS0830 = await _context.NCS0830s.FindAsync(id);
            if (nCS0830 == null)
            {
                return NotFound();
            }
            return View(nCS0830);
        }

        // POST: NCS0830s/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string id, [Bind("NCSId,NCSName,NCSGender")] NCS0830 nCS0830)
        {
            if (id != nCS0830.NCSId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(nCS0830);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!NCS0830Exists(nCS0830.NCSId))
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
            return View(nCS0830);
        }

        // GET: NCS0830s/Delete/5
        public async Task<IActionResult> Delete(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var nCS0830 = await _context.NCS0830s
                .FirstOrDefaultAsync(m => m.NCSId == id);
            if (nCS0830 == null)
            {
                return NotFound();
            }

            return View(nCS0830);
        }

        // POST: NCS0830s/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(string id)
        {
            var nCS0830 = await _context.NCS0830s.FindAsync(id);
            _context.NCS0830s.Remove(nCS0830);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool NCS0830Exists(string id)
        {
            return _context.NCS0830s.Any(e => e.NCSId == id);
        }
    }
}
