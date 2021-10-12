using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using AssignmentSample.Models;

namespace AssignmentSample.Pages_Content
{
    public class CreateModel : PageModel
    {
        private readonly AssignmentSampleContentContext _context;

        public CreateModel(AssignmentSampleContentContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Content Content { get; set; }

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Content.Add(Content);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
