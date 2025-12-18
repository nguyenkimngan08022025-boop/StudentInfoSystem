using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.ComponentModel.DataAnnotations;
using SecondRazorPage.Data;
using Microsoft.EntityFrameworkCore;

namespace SecondRazorPage.Pages.LoginPage
{
    public class TeacherLoginModel : PageModel
    {
        private readonly ApplicationDbContext _context;

        public TeacherLoginModel(ApplicationDbContext context)
        {
            _context = context;
        }

        [BindProperty]
        [Required(ErrorMessage = "Vui lòng nhập Mã Giảng Viên")]
        public string? TeacherCode { get; set; }

        [BindProperty]
        [Required(ErrorMessage = "Vui lòng nhập Mật khẩu")]
        public string? Password { get; set; }

        public void OnGet()
        {
        }

      /*  public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            var teacher = await _context.Teachers
                                .FirstOrDefaultAsync(t => t.MSGV == TeacherCode /*&& t.pass == Password*///); */  // để kiểm tra luôn mật khẩu

         /*   if (teacher == null)
            {
                ModelState.AddModelError(string.Empty, "Mã Giảng Viên không tồn tại!");
                return Page();
            }

            return RedirectToPage("/Teachers/Profile", new { teacherCode = teacher.MSGV });
        } */


        public IActionResult OnPost()
        {
            if (string.IsNullOrWhiteSpace(TeacherCode))
            {
                ModelState.AddModelError("", "Vui lòng nhập mã số sinh viên");
                return Page();
            }

            // kiem tra ma so co dung hay khong
            var exists = _context.Teachers
                                 .Any(s => s.MSGV == TeacherCode);

            if (!exists)
            {
                ModelState.AddModelError("", "Mã Giảng Viên không tồn tại!");
                return Page();
            }
            else
            {
                HttpContext.Response.Cookies.Append(
        "MSGV",
        TeacherCode,
        new CookieOptions ////dùng cookie để lưu mã số dễ hơn
        {
            HttpOnly = true,
            Secure = true,
            IsEssential = true
        });

                return RedirectToPage("/Teachers/Profile");
            }


        }
    }
}