using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using HackingData.Models;

namespace HackingData.Pages.Hackers
{
    public class EditModel : PageModel
    {
        private readonly HackersHackerPagesContext _context;

        public EditModel(HackersHackerPagesContext context)
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

        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(HackData).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!HackDataExists(HackData.ID))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return RedirectToPage("./Index");
        }

        private bool HackDataExists(int id)
        {
            return _context.HackData.Any(e => e.ID == id);
        }
    }
}
