using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using DTTBaiThiLai.Models;

namespace DTTBaiThiLai.Controllers
{
    public class DTT893Controller : Controller
    {
        private readonly LTQLDb _context;

        public DTT893Controller(LTQLDb context)
        {
            _context = context;
        }

        // GET: DTT893
        public async Task<IActionResult> Index()
        {
            return View(await _context.DTT893.ToListAsync());
        }

        // GET: DTT893/Details/5
        public async Task<IActionResult> Details(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var dTT893 = await _context.DTT893
                .FirstOrDefaultAsync(m => m.HoTen == id);
            if (dTT893 == null)
            {
                return NotFound();
            }

            return View(dTT893);
        }

        // GET: DTT893/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: DTT893/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("HoTen,ID,Ngaysinh")] DTT893 dTT893)
        {
            if (ModelState.IsValid)
            {
                _context.Add(dTT893);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(dTT893);
        }

        // GET: DTT893/Edit/5
        public async Task<IActionResult> Edit(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var dTT893 = await _context.DTT893.FindAsync(id);
            if (dTT893 == null)
            {
                return NotFound();
            }
            return View(dTT893);
        }

        // POST: DTT893/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string id, [Bind("HoTen,ID,Ngaysinh")] DTT893 dTT893)
        {
            if (id != dTT893.HoTen)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(dTT893);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!DTT893Exists(dTT893.HoTen))
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
            return View(dTT893);
        }

        // GET: DTT893/Delete/5
        public async Task<IActionResult> Delete(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var dTT893 = await _context.DTT893
                .FirstOrDefaultAsync(m => m.HoTen == id);
            if (dTT893 == null)
            {
                return NotFound();
            }

            return View(dTT893);
        }

        // POST: DTT893/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(string id)
        {
            var dTT893 = await _context.DTT893.FindAsync(id);
            if (dTT893 != null)
            {
                _context.DTT893.Remove(dTT893);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool DTT893Exists(string id)
        {
            return _context.DTT893.Any(e => e.HoTen == id);
        }
    }
}
