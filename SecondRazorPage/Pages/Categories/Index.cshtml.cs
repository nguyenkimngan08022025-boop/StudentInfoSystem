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
        public async Task OnGetAsync(string studentCode)
        {
            if (!string.IsNullOrEmpty(studentCode))
            {
                Student = await _context.Category
                    .FirstOrDefaultAsync(c => c.StudentCode == studentCode);
            }
            else
            {
               
                Student = await _context.Category.FirstOrDefaultAsync();
            }
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
