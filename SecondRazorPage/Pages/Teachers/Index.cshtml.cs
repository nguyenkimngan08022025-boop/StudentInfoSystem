using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using SecondRazorPage.Data;
using SecondRazorPage.Model; // Đảm bảo dòng này đúng với namespace chứa class Teacher của bạn

namespace SecondRazorPage.Pages.Teachers
{
    public class IndexModel : PageModel
    {
        private readonly ApplicationDbContext _context;

        public IndexModel(ApplicationDbContext context)
        {
            _context = context;
        }

        public Teacher CurrentTeacher { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(string? teacherCode)
        {
            if (string.IsNullOrEmpty(teacherCode))
            {
                return RedirectToPage("/LoginPage/Teacher");
            }

            CurrentTeacher = await _context.Teachers
                                   .FirstOrDefaultAsync(m => m.MSGV == teacherCode);

            if (CurrentTeacher == null)
            {
                return RedirectToPage("/LoginPage/Teacher");
            }

            return Page();
        }
    }
}