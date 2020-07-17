using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using SacramentMeetingPlanner.Data;
using SacramentMeetingPlanner.Models;

namespace SacramentMeetingPlanner.Controllers
{
    public class SacramentMeetingsController : Controller
    {
        private readonly SacramentContext _context;

        public SacramentMeetingsController(SacramentContext context)
        {
            _context = context;
        }

        // GET: SacramentMeetings
        public async Task<IActionResult> Index()
        {
            return View(await _context.SacramentMeetings.ToListAsync());
        }

        // GET: SacramentMeetings/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var sacramentMeeting = await _context.SacramentMeetings
               .Include(s => s.Speaker)
               .AsNoTracking()
               .FirstOrDefaultAsync(m => m.ID == id);
            //var sacramentMeeting = await _context.SacramentMeetings
            //  .FirstOrDefaultAsync(m => m.ID == id);
            if (sacramentMeeting == null)
            {
                return NotFound();
            }

            return View(sacramentMeeting);
        }

        // GET: SacramentMeetings/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: SacramentMeetings/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("SacramentDate,ConductingBishopric,OpeningPrayer,OpeningHymn," +
            "SacramentHymn,IntermediateHymn,ClosingHymn,ClosingPrayer")] SacramentMeeting sacramentMeeting)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    _context.Add(sacramentMeeting);
                    await _context.SaveChangesAsync();
                    return RedirectToAction(nameof(Index));
                }
            }
            catch (DbUpdateException /* ex */)
            {
                //Log the error (uncomment ex variable name and write a log.
                ModelState.AddModelError("", "Unable to save changes. " +
                    "Try again, and if the problem persists " +
                    "see your system administrator.");
            }
            //IQueryable<string> MemberQuery = from m in _context.Members
            //                               orderby m.LastName
            //                             select new ViewModel { m.FirstName, m.LastName};
            // var member = Select FirstName, LastName 

            /*  var member = from m in _context.Members
                             select m;
              member = (m => s.LastName);


              string query = "SELECT * FROM Department WHERE DepartmentID = {0}";
              var department = await _context.Departments
                  .FromSql(query, id)
                  .Include(d => d.Administrator)
                  .AsNoTracking()
                  .FirstOrDefaultAsync();*/
            string query = "SELECT FirstName, LastName FROM Members";
            var member = await _context.Members
                .FromSql(query)
               // .Include(d => d.Administrator)
                .AsNoTracking()
                .FirstOrDefaultAsync();
            return View(sacramentMeeting);
        }

        // GET: SacramentMeetings/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var sacramentMeeting = await _context.SacramentMeetings.FindAsync(id);
            if (sacramentMeeting == null)
            {
                return NotFound();
            }
           
            return View(sacramentMeeting);
        }
        

        private object FromSql(string query)
        {
            throw new NotImplementedException();
        }

        // POST: SacramentMeetings/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ID,SacramentDate,ConductingBishopric,OpeningPrayer,OpeningHymn," +
            "SacramentHymn,IntermediateHymn,ClosingHymn,ClosingPrayer")] SacramentMeeting sacramentMeeting)
        {
            if (id != sacramentMeeting.ID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(sacramentMeeting);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!SacramentMeetingExists(sacramentMeeting.ID))
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
            return View(sacramentMeeting);
        }

        // GET: SacramentMeetings/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var sacramentMeeting = await _context.SacramentMeetings
                .FirstOrDefaultAsync(m => m.ID == id);
            if (sacramentMeeting == null)
            {
                return NotFound();
            }

            return View(sacramentMeeting);
        }

        // POST: SacramentMeetings/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var sacramentMeeting = await _context.SacramentMeetings.FindAsync(id);
            _context.SacramentMeetings.Remove(sacramentMeeting);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool SacramentMeetingExists(int id)
        {
            return _context.SacramentMeetings.Any(e => e.ID == id);
        }
    }
}
