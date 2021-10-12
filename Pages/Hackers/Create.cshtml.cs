using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using HackingData.Models;

namespace HackingData.Pages.Hackers
{
    public class CreateModel : PageModel
    {
        private readonly HackersHackerPagesContext _context;

        public CreateModel(HackersHackerPagesContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public HackData HackData { get; set; }

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.HackData.Add(HackData);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
