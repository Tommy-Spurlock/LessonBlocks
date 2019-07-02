using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using DanceBlocks.Data;
using DanceBlocks.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Authorization;
using DanceBlocks.Models.StudentViewModels;

namespace DanceBlocks.Controllers
{
    public class StudentsController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly UserManager<ApplicationUser> _userManager;


        public StudentsController(ApplicationDbContext context, UserManager<ApplicationUser> userManager)
        {
            _userManager = userManager;
            _context = context;
        }

        private Task<ApplicationUser> GetCurrentUserAsync() => _userManager.GetUserAsync(HttpContext.User);

        [Authorize]

        // GET: Students
        public async Task<IActionResult> Index()
        {
           ApplicationUser user = await GetCurrentUserAsync();
            var applicationDbContext = _context.Students
                .Include(s => s.DanceType)
                .Include(s => s.SkillLevel)
                .Where(client => client.UserId == user.Id);
            return View(await applicationDbContext.ToListAsync());
        }

        // GET: Students/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var student = await _context.Students
                .Include(s => s.DanceType)
                .Include(s => s.SkillLevel)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (student == null)
            {
                return NotFound();
            }

            return View(student);
        }

        // GET: Students/Create
        public IActionResult Create()
        {

            CreateStudentViewModel newStudent = new CreateStudentViewModel()
            {
               
                DanceTypes = new SelectList(_context.DanceTypes, "Id", "Name"),
                SkillLevels = new SelectList(_context.SkillLevels, "Id", "Level")
                
            };
             
          
            return View(newStudent);
        }

        // POST: Students/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(CreateStudentViewModel newStudent)
        {

            ApplicationUser user = await GetCurrentUserAsync();

            newStudent.Student.IsActive = true;
            newStudent.Student.UserId = user.Id;
            newStudent.Student.StudentStartDate = DateTime.Now;
            newStudent.DanceTypes = new SelectList(_context.DanceTypes, "Id", "Name");
            newStudent.SkillLevels = new SelectList(_context.SkillLevels, "Id", "Level");

            if (ModelState.IsValid)
            {
                _context.Add(newStudent.Student);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }


            return View(newStudent);
        }

        // GET: Students/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var student = await _context.Students.FindAsync(id);
            if (student == null)
            {
                return NotFound();
            }
            ViewData["DanceTypeId"] = new SelectList(_context.DanceTypes, "Id", "Name", student.DanceTypeId);
            ViewData["SkillLevelId"] = new SelectList(_context.SkillLevels, "Id", "Id", student.SkillLevelId);
            return View(student);
        }

        // POST: Students/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,FirstName,LastName,PhoneNumber,Email,Address,StudentStartDate,IsActive,DanceTypeId,SkillLevelId,UserId")] Student student)
        {
            if (id != student.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(student);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!StudentExists(student.Id))
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
            ViewData["DanceTypeId"] = new SelectList(_context.DanceTypes, "Id", "Name", student.DanceTypeId);
            ViewData["SkillLevelId"] = new SelectList(_context.SkillLevels, "Id", "Id", student.SkillLevelId);
            return View(student);
        }

        // GET: Students/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var student = await _context.Students
                .Include(s => s.DanceType)
                .Include(s => s.SkillLevel)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (student == null)
            {
                return NotFound();
            }

            return View(student);
        }

        // POST: Students/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var student = await _context.Students.FindAsync(id);
            _context.Students.Remove(student);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool StudentExists(int id)
        {
            return _context.Students.Any(e => e.Id == id);
        }
    }
}
