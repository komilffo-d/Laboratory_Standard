using Laboratory_Standard.Database.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace Laboratory_Standard.Pages.Experts
{
    public class IndexModel : PageModel
    {

        private readonly AppDbContext _context;

        public IndexModel(AppDbContext context)
        {
            _context = context;
        }

        public IList<ExpertDb> ExpertDb { get; set; } = default!;

        public void OnGetAsync(string? group)
        {
            ExpertDb = _context.Set<ExpertDb>().AsNoTracking().ToList();
        }
    }
}
