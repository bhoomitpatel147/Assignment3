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
    public class IndexModel : PageModel
    {
        private readonly AssignmentSampleContentContext _context;

        public IndexModel(AssignmentSampleContentContext context)
        {
            _context = context;
        }

        public IList<Content> Content { get;set; }

        public async Task OnGetAsync()
        {
            Content = await _context.Content.ToListAsync();
        }
    }
}
