using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using SecondRazorPage.Data;   
using System.Linq;

namespace SecondRazorPage.Pages.LoginPage
{
    public class StudentLoginModel : PageModel
    {
        private readonly ApplicationDbContext _context;

        public StudentLoginModel(ApplicationDbContext context)
        {
            _context = context;
        }

        [BindProperty]
        public string StudentId { get; set; }

        [BindProperty]
        public string Password { get; set; }   

        public void OnGet()
        {
        }

        public IActionResult OnPost()
        {
            if (string.IsNullOrWhiteSpace(StudentId))
            {
                ModelState.AddModelError("", "Vui lòng nhập mã số sinh viên");
                return Page();
            }

            // kiem tra ma so co dung hay khong
            var exists = _context.Category
                                 .Any(s => s.StudentCode == StudentId);

            if (!exists)
            {
                ModelState.AddModelError("", "Không tìm thấy MSSV trong hệ thống");
                return Page();
            }
            else
            {
                HttpContext.Response.Cookies.Append(
        "StudentCode",    
        StudentId,       
        new CookieOptions
        {
            HttpOnly = true,  
            Secure = true,
            IsEssential = true
        });

                return RedirectToPage("/Categories/Index");
            }
               
               
        }
    }
}
