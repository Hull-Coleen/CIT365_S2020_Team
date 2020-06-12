using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using MegaDesk.Models;

namespace MegaDesk.Pages.DeskQuotes
{
    public class IndexModel : PageModel
    {
        private readonly MegaDesk.Models.MegaDeskContext _context;

        public IndexModel(MegaDesk.Models.MegaDeskContext context)
        {
            _context = context;
        }

        public IList<DeskQuote> DeskQuote { get;set; }

        // This is for the sorting        
        public string SortDate { get; set; }
        public string SortName { get; set; }
        public string CurrentFilter { get; set; }       

        

        public async Task OnGetAsync(string sortOrder, string searchString)
        {
            //BookSelected = searchBook;
            CurrentFilter = searchString;

            // Use LINQ to get the search and sorting
            IQueryable<DeskQuote> deskQuery = from s in _context.DeskQuote
                                              orderby s.FirstName
                                              select s;
           

            var desks = from s in _context.DeskQuote
                             select s;

            if (!String.IsNullOrEmpty(searchString))
            {
                desks = desks.Where(s => s.FirstName.Contains(searchString));
            }                       

            // Adding the sorting code
            SortDate = sortOrder == "QuoteDate" ? "QuoteDate_desc" : "QuoteDate";
            SortName = String.IsNullOrEmpty(sortOrder) ? "FirstName_desc" : "";



            switch (sortOrder)
            {
                case "FirstName_desc":
                    desks = desks.OrderByDescending(s => s.FirstName);
                    break;
                case "QuoteDate":
                    desks = desks.OrderBy(s => s.QuoteDate);
                    break;
                case "QuoteDate_desc":
                    desks = desks.OrderByDescending(s => s.QuoteDate);
                    break;
                default:
                    desks = desks.OrderBy(s => s.FirstName);
                    break;
            }


            DeskQuote = await deskQuery.AsNoTracking().ToListAsync();           
            DeskQuote = await desks.ToListAsync();          
        
          
        }
    }
}
