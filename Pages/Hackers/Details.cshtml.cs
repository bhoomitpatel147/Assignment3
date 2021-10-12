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
    public class DetailsModel : PageModel
    {
        private readonly HackersHackerPagesContext _context;

        public DetailsModel(HackersHackerPagesContext context)
        {
            _context = context;
        }

        public HackData HackData { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            HackData = await _context.HackData.FirstOrDefaultAsync(m => m.ID == id);

            if (HackData == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
