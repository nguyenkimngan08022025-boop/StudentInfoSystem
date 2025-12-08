using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using SecondRazorPage.Data;
using SecondRazorPage.Model;
using System.Collections.Generic; 

namespace SecondRazorPage.Pages.Teachers
{
    public class ScheduleModel : PageModel
    {
        private readonly ApplicationDbContext _context;

        public ScheduleModel(ApplicationDbContext context)
        {
            _context = context;
        }

        // 1. Biến lưu thông tin giáo viên (để hiện tên trên header)
        public Teacher CurrentTeacher { get; set; } = default!;

        // 2. Class phụ để lưu cấu trúc Lịch dạy (Chỉ dùng tạm ở đây)
        public class LichDayItem
        {
            public string Thu { get; set; }      // Thứ 2, Thứ 3...
            public string Ngay { get; set; }     // 10/12/2024
            public string Ca { get; set; }       // Sáng (1-3)
            public string TenMon { get; set; }
            public string MaLop { get; set; }
            public string Phong { get; set; }
        }

        // 3. Danh sách lịch dạy sẽ gửi sang giao diện
        public List<LichDayItem> DanhSachLich { get; set; } = new List<LichDayItem>();

        public async Task<IActionResult> OnGetAsync(string? teacherCode)
        {
            // Kiểm tra đăng nhập
            if (string.IsNullOrEmpty(teacherCode))
            {
                return RedirectToPage("/LoginPage/Teacher");
            }

            // Lấy thông tin giáo viên
            CurrentTeacher = await _context.Teachers
                                   .FirstOrDefaultAsync(m => m.MSGV == teacherCode);

            if (CurrentTeacher == null)
            {
                return RedirectToPage("/LoginPage/Teacher");
            }

            // --- TẠO DỮ LIỆU GIẢ (MOCK DATA) ---
            // Sau này bạn sẽ thay đoạn này bằng câu lệnh lấy từ Database
            DanhSachLich.Add(new LichDayItem { Thu = "Thứ 2", Ngay = "09/12", Ca = "Sáng (Tiết 1-3)", TenMon = "Cấu trúc dữ liệu", MaLop = "24CTT5", Phong = "C32" });
            DanhSachLich.Add(new LichDayItem { Thu = "Thứ 4", Ngay = "11/12", Ca = "Chiều (Tiết 7-9)", TenMon = "Nhập môn lập trình", MaLop = "24CTT5", Phong = "F102" });
            DanhSachLich.Add(new LichDayItem { Thu = "Thứ 6", Ngay = "13/12", Ca = "Sáng (Tiết 1-3)", TenMon = "Hóa đại cương", MaLop = "25HOH1", Phong = "B40" });

            return Page();
        }
    }
}