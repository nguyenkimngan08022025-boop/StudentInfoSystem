using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using SecondRazorPage.Data;
using SecondRazorPage.Model;
using Microsoft.EntityFrameworkCore;




namespace SecondRazorPage.Pages.Categories
{

    public class IndexModel : PageModel
    {
        private readonly ApplicationDbContext _context;

        public IndexModel(ApplicationDbContext context)
        {
            _context = context;
        }

        /* public Category Student { get; set; }

         public async Task OnGetAsync(string? StudentCode)
         {
             if (StudentCode.HasValue)
             {
                 Student = await _context.Category
                     .FirstOrDefaultAsync(c => c.StudentCode == StudentCode.Value);
             }
             else
             {
                 // if no id then take the first one temporarily
                 Student = await _context.Category.FirstOrDefaultAsync();
             }
         }*/
        public Category Student { get; set; }

        // MSSV is string

        
        public List<BangDiem> BangDiem { get; set; }
        public List<HocPhi> HocPhi { get; set; }
        public List<DiemRenLuyen> DiemRenLuyen { get; set; }



        public List<HocBong> HocBong { get; set; }
        public List<KhenThuong> KhenThuong { get; set; }
        public List<KyLuat> KyLuat { get; set; }
        public List<LichThi> LichThi { get; set; }

        public List<ThoiKhoaBieu> ThoiKhoaBieu { get; set; }





        public async Task<IActionResult> OnGetAsync()
        {
            var studentCode = HttpContext.Request.Cookies["StudentCode"];
            if (!string.IsNullOrEmpty(studentCode))
            {
                Student = await _context.Category
                    .FirstOrDefaultAsync(c => c.StudentCode == studentCode);



                BangDiem = await _context.BangDiem
                .Where(r => r.StudentCode == studentCode)
                .ToListAsync();

                HocPhi = await _context.HocPhi
                    .Where(f => f.StudentCode == studentCode)
                    .ToListAsync();

                DiemRenLuyen = await _context.DiemRenLuyen
                    .Where(n => n.StudentCode == studentCode)
                    .ToListAsync();


                HocBong = await _context.HocBong
                    .Where(n => n.StudentCode == studentCode)
                    .ToListAsync();
                KhenThuong = await _context.KhenThuong
                    .Where(n => n.StudentCode == studentCode)
                    .ToListAsync();

                KyLuat = await _context.KyLuat
                    .Where(n => n.StudentCode == studentCode)
                    .ToListAsync();
                LichThi = await _context.LichThi
                    .Where(n => n.StudentCode == studentCode)
                    .ToListAsync();
                ThoiKhoaBieu = await _context.ThoiKhoaBieu
                    .Where(n => n.StudentCode == studentCode)
                    .ToListAsync();



                return Page();
            }
            else
            {

                return RedirectToPage("/LoginPage/Index");
            }
        }
        public IActionResult OnPostLogout()
        {
            
            Response.Cookies.Delete("StudentCode");

            
            return RedirectToPage("/LoginPage/Index");
        }

    }





    /*public class IndexModel : PageModel
    {
        //private object 
        private readonly ApplicationDbContext _db;

        public IEnumerable<Category> Categories { get; set;  }
        //goes with constructor to set initial values (public property; not this time) 
        public IndexModel(ApplicationDbContext db)
        {
            _db = db; 
        }
        public void OnGet()
        {
            Categories = _db.Category; 
        }
    }*/
}
