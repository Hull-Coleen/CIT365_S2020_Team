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

        public async Task OnGetAsync()
        {
            DeskQuote = await _context.DeskQuote.ToListAsync();
        }
    }
}
