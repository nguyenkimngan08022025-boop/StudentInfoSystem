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

        // Biến này chứa toàn bộ thông tin giáo viên để hiển thị ra màn hình
        public Teacher CurrentTeacher { get; set; } = default!;

        // Hàm này chạy ngay khi trang web được tải
        public async Task<IActionResult> OnGetAsync(string? teacherCode)
        {
            // 1. Kiểm tra nếu không có mã giáo viên gửi sang -> Đá về trang đăng nhập
            if (string.IsNullOrEmpty(teacherCode))
            {
                return RedirectToPage("/LoginPage/Teacher");
            }

            // 2. Tìm giáo viên trong Database theo MSGV
            CurrentTeacher = await _context.Teachers
                                   .FirstOrDefaultAsync(m => m.MSGV == teacherCode);

            // 3. Nếu tìm không thấy -> Cũng đá về trang đăng nhập
            if (CurrentTeacher == null)
            {
                return RedirectToPage("/LoginPage/Teacher");
            }

            return Page(); // 4. Nếu OK thì tải trang web lên
        }
    }
}