using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using DanceBlocks.Data;
using DanceBlocks.Models;

namespace DanceBlocks.Controllers
{
    public class StepsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public StepsController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Steps
        public async Task<IActionResult> Index()
        {
            var applicationDbContext = _context.Steps.Include(s => s.DanceType)
                .Include(s => s.SkillLevel)
                .OrderBy(s => s.DanceType.Name)
                ;
            return View(await applicationDbContext.ToListAsync());
        }

        // GET: Steps/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var step = await _context.Steps
                .Include(s => s.DanceType)
                .Include(s => s.SkillLevel)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (step == null)
            {
                return NotFound();
            }

            return View(step);
        }

        // GET: Steps/Create
        public IActionResult Create()
        {
            ViewData["DanceTypeId"] = new SelectList(_context.DanceTypes, "Id", "Name");
            ViewData["SkillLevelId"] = new SelectList(_context.SkillLevels, "Id", "Id");
            return View();
        }

        // POST: Steps/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Name,Description,DanceTypeId,SkillLevelId")] Step step)
        {
            if (ModelState.IsValid)
            {
                _context.Add(step);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["DanceTypeId"] = new SelectList(_context.DanceTypes, "Id", "Name", step.DanceTypeId);
            ViewData["SkillLevelId"] = new SelectList(_context.SkillLevels, "Id", "Id", step.SkillLevelId);
            return View(step);
        }

        // GET: Steps/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var step = await _context.Steps.FindAsync(id);
            if (step == null)
            {
                return NotFound();
            }
            ViewData["DanceTypeId"] = new SelectList(_context.DanceTypes, "Id", "Name", step.DanceTypeId);
            ViewData["SkillLevelId"] = new SelectList(_context.SkillLevels, "Id", "Id", step.SkillLevelId);
            return View(step);
        }

        // POST: Steps/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Name,Description,DanceTypeId,SkillLevelId")] Step step)
        {
            if (id != step.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(step);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!StepExists(step.Id))
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
            ViewData["DanceTypeId"] = new SelectList(_context.DanceTypes, "Id", "Name", step.DanceTypeId);
            ViewData["SkillLevelId"] = new SelectList(_context.SkillLevels, "Id", "Id", step.SkillLevelId);
            return View(step);
        }

        // GET: Steps/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var step = await _context.Steps
                .Include(s => s.DanceType)
                .Include(s => s.SkillLevel)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (step == null)
            {
                return NotFound();
            }

            return View(step);
        }

        // POST: Steps/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var step = await _context.Steps.FindAsync(id);
            _context.Steps.Remove(step);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool StepExists(int id)
        {
            return _context.Steps.Any(e => e.Id == id);
        }
    }
}
