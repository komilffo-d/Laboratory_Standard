using Laboratory_Standard.Database.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Laboratory_Standard.Pages.Experts
{
    public class CreateModel : PageModel
    {
        private readonly AppDbContext _context;

        public CreateModel(AppDbContext context)
        {
            _context = context;
        }

        public IActionResult OnGet() { 

            return Page();
        }

        [BindProperty]
        public ExpertDb ExpertDb { get; set; } = default!;

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Experts.Add(ExpertDb);
            await _context.SaveChangesAsync();

            return RedirectToPage("Index");
        }
    }
}
