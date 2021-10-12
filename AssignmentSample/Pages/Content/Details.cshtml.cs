using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using AssignmentSample.Models;

namespace AssignmentSample.Pages_Content
{
    public class DetailsModel : PageModel
    {
        private readonly AssignmentSampleContentContext _context;

        public DetailsModel(AssignmentSampleContentContext context)
        {
            _context = context;
        }

        public Content Content { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Content = await _context.Content.FirstOrDefaultAsync(m => m.ID == id);

            if (Content == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
