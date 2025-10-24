using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using TranDucThinh_231230917_de01.models;

namespace TranDucThinh_231230917_de01.Controllers
{
    public class TranDucThinhComputersController : Controller
    {
        private readonly TranDucThinh231230917De01Context _context;

        public TranDucThinhComputersController(TranDucThinh231230917De01Context context)
        {
            _context = context;
        }

        // GET: TranDucThinhComputers
        public async Task<IActionResult> TranDucThinhIndex()
        {
            return View(await _context.TranDucThinhComputers.ToListAsync());
        }

        // GET: TranDucThinhComputers/Details/5
        public async Task<IActionResult> TranDucThinhDetails(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tranDucThinhComputer = await _context.TranDucThinhComputers
                .FirstOrDefaultAsync(m => m.TranDucThinhComId == id);
            if (tranDucThinhComputer == null)
            {
                return NotFound();
            }

            return View(tranDucThinhComputer);
        }

        // GET: TranDucThinhComputers/Create
        public IActionResult TranDucThinhCreate()
        {
            return View();
        }

        // POST: TranDucThinhComputers/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> TranDucThinhCreate([Bind("TranDucThinhComId,TranDucThinhComName,TranDucThinhComPrice,TranDucThinhComImage,TranDucThinhComStatus")] TranDucThinhComputer tranDucThinhComputer)
        {
            if (ModelState.IsValid)
            {
                _context.Add(tranDucThinhComputer);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(TranDucThinhIndex));
            }
            return View(tranDucThinhComputer);
        }

        // GET: TranDucThinhComputers/Edit/5
        public async Task<IActionResult> TranDucThinhEdit(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tranDucThinhComputer = await _context.TranDucThinhComputers.FindAsync(id);
            if (tranDucThinhComputer == null)
            {
                return NotFound();
            }
            return View(tranDucThinhComputer);
        }

        // POST: TranDucThinhComputers/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> TranDucThinhEdit(string id, [Bind("TranDucThinhComId,TranDucThinhComName,TranDucThinhComPrice,TranDucThinhComImage,TranDucThinhComStatus")] TranDucThinhComputer tranDucThinhComputer)
        {
            if (id != tranDucThinhComputer.TranDucThinhComId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(tranDucThinhComputer);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!TranDucThinhComputerExists(tranDucThinhComputer.TranDucThinhComId))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(TranDucThinhIndex));
            }
            return View(tranDucThinhComputer);
        }

        // GET: TranDucThinhComputers/Delete/5
        public async Task<IActionResult> TranDucThinhDelete(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tranDucThinhComputer = await _context.TranDucThinhComputers
                .FirstOrDefaultAsync(m => m.TranDucThinhComId == id);
            if (tranDucThinhComputer == null)
            {
                return NotFound();
            }

            return View(tranDucThinhComputer);
        }

        // POST: TranDucThinhComputers/Delete/5
        [HttpPost, ActionName("TranDucThinhDelete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> TranDucThinhDeleteConfirmed(string id)
        {
            var tranDucThinhComputer = await _context.TranDucThinhComputers.FindAsync(id);
            if (tranDucThinhComputer != null)
            {
                _context.TranDucThinhComputers.Remove(tranDucThinhComputer);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(TranDucThinhIndex));
        }

        private bool TranDucThinhComputerExists(string id)
        {
            return _context.TranDucThinhComputers.Any(e => e.TranDucThinhComId == id);
        }
    }
}
