using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace Laboratory_Standard.Pages.Experts
{
    public class DeleteModel : PageModel
    {
        private readonly AppDbContext _context;

        public DeleteModel(AppDbContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> OnPostAsync(int id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var subjectdb = await _context.Experts.FindAsync(id);
            if (subjectdb != null)
            {
                _context.Experts.Remove(subjectdb);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("Index");
        }
    }
}
