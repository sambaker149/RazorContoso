using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using RazorContoso.Data;
using RazorContoso.Models;

namespace RazorContoso.Pages.Instructors
{
    public class DeleteModel : PageModel
    {
        private readonly RazorContoso.Data.SchoolContext _context;

        public DeleteModel(RazorContoso.Data.SchoolContext context)
        {
            _context = context;
        }

        [BindProperty]
      public Instructor Instructor { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.Instructors == null)
            {
                return NotFound();
            }

            var instructor = await _context.Instructors.FirstOrDefaultAsync(m => m.InstructorID == id);

            if (instructor == null)
            {
                return NotFound();
            }
            else 
            {
                Instructor = instructor;
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null || _context.Instructors == null)
            {
                return NotFound();
            }
            var instructor = await _context.Instructors.FindAsync(id);

            if (instructor != null)
            {
                Instructor = instructor;
                _context.Instructors.Remove(Instructor);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
