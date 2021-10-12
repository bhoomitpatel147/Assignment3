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
    public class DeleteModel : PageModel
    {
        private readonly HackersHackerPagesContext _context;

        public DeleteModel(HackersHackerPagesContext context)
        {
            _context = context;
        }

        [BindProperty]
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

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            HackData = await _context.HackData.FindAsync(id);

            if (HackData != null)
            {
                _context.HackData.Remove(HackData);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
