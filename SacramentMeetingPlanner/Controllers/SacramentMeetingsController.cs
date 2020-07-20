using System;
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
            ViewData["MemberID"] = new SelectList(_context.Members.OrderBy(p => p.LastName), "FullName", "FullName");
            ViewData["HymnID"] = new SelectList(_context.Hymns.
                                             Where(p => p.PageNumber < 100 || p.PageNumber > 150).
                                             OrderBy(p => p.Title), "Title", "Title");
            ViewData["BishID"] = new SelectList(_context.Members.
                                             Where(p => p.Calling == "Bishopric Counsel" || p.Calling == "Bishop").
                                             OrderBy(p => p.LastName), "FullName", "FullName");
            ViewData["SacramentID"] = new SelectList(_context.Hymns.
                                             Where(p => p.PageNumber > 99 && p.PageNumber < 151).
                                             OrderBy(p => p.Title), "Title", "Title");

            return View();
        }
     
        // POST: SacramentMeetings/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("SacramentDate,Topic,ConductingBishopric,OpeningPrayer,OpeningHymn," +
            "SacramentHymn,IntermediateHymn,ClosingHymn,ClosingPrayer,Speaker1,Speaker2,Speaker3,Speaker4,Speaker5,Speaker6")] SacramentMeeting sacramentMeeting)
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

            return View(sacramentMeeting);
        }

        // GET: SacramentMeetings/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            ViewData["MemberID"] = new SelectList(_context.Members.OrderBy(p => p.LastName), "FullName", "FullName");
            ViewData["HymnID"] = new SelectList(_context.Hymns.
                                             Where(p => p.PageNumber < 100 || p.PageNumber > 150).
                                             OrderBy(p => p.Title), "Title", "Title");
            ViewData["BishID"] = new SelectList(_context.Members.
                                             Where(p => p.Calling == "Bishopric Counsel" || p.Calling == "Bishop").
                                             OrderBy(p => p.LastName), "FullName", "FullName");
            ViewData["SacramentID"] = new SelectList(_context.Hymns.
                                             Where(p => p.PageNumber > 99 && p.PageNumber < 151).
                                             OrderBy(p => p.Title), "Title", "Title");
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
        public async Task<IActionResult> Edit(int id, [Bind("ID,SacramentDate,Topic,ConductingBishopric,OpeningPrayer,OpeningHymn," +
            "SacramentHymn,IntermediateHymn,ClosingHymn,ClosingPrayer,Speaker1,Speaker2,Speaker3,Speaker4,Speaker5,Speaker6")] SacramentMeeting sacramentMeeting)
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
