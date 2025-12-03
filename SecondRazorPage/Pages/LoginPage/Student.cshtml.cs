
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.ComponentModel.DataAnnotations;

namespace SecondRazorPage.Pages.LoginPage
{
    public class StudentLoginModel : PageModel
    {
        [BindProperty]
        [Required]
        public string? StudentId { get; set; }

        [BindProperty]
        [Required]
        public string? Password { get; set; }

        public void OnGet()
        {
        }

        public IActionResult OnPost()
        {
            string code = StudentId; 
            if (!ModelState.IsValid)
            {
                return Page(); // show validation messages
            }

            //  Fake check – replace with your real logic later
            // For demo: any non-empty ID + password = success
            // or you can hard-code: if (StudentId == "2312345" && Password == "123")
            bool loginOk = true;

            if (!loginOk)
            {
                ModelState.AddModelError(string.Empty, "Wrong MSSV or password");
                return Page();
            }

            // TODO: set cookie/session if you want real auth

            //  Redirect to main page after login
            return RedirectToPage("/Categories/Index",new {studentCode = code});
        }
    }
}
