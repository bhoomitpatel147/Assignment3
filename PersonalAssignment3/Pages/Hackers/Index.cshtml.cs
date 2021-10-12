using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using HackingData.Models;

namespace HackingData.Pages.Hackers
{
    public class IndexModel : PageModel
    {
        private readonly HackersHackerPagesContext _context;

        public IndexModel(HackersHackerPagesContext context)
        {
            _context = context;
        }

        public IList<HackData> HackData { get;set; }

        public async Task OnGetAsync()
        {
            HackData = await _context.HackData.ToListAsync();
        }
    }
}
