using RazorContoso.Models;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace RazorContoso.Pages.Courses
{
    public class IndexModel : PageModel
    {
        private readonly Data.SchoolContext _context;

        public IndexModel(Data.SchoolContext context)
        {
            _context = context;
        }

        public IList<Module> Modules { get; set; }

        public async Task OnGetAsync()
        {
            Modules = await _context.Modules
                .Include(c => c.Department)
                .AsNoTracking()
                .ToListAsync();
        }
    }
}