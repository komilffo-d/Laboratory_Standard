using Lab_9.Database.Entities;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Security.Claims;

namespace Laboratory_Standard.Pages.Login
{
    [IgnoreAntiforgeryToken]
    public class IndexModel : PageModel
    {
        private readonly AppDbContext _context;
        public IndexModel(AppDbContext context)
        {
            _context = context;
        }
        public IActionResult? OnGet()
        {
            if (User is not null && User.Identity is not null && User.Identity.IsAuthenticated)
                return Redirect("/Index");
            return Page();
        }

        public async Task<IActionResult> OnPost(string? returnUrl)
        {
            var form = Request.Form;

            string? login = form["login"];
            string? password = form["password"];


            AccountDb? person = _context.Accounts.FirstOrDefault(p => p.Login == login && p.Password == password);

            if (person is null)
            {
                ModelState.AddModelError("Data", "Неправильный логин и/или пароль!");
                return Page();

            }


            var claims = new List<Claim> { new Claim(ClaimTypes.Name, person.Login) };
            ClaimsIdentity claimsIdentity = new ClaimsIdentity(claims, "Cookies");
            await HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme, new ClaimsPrincipal(claimsIdentity));
            return Redirect("/Index");
        }
    }
}
