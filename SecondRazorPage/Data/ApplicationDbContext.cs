using Microsoft.EntityFrameworkCore;
using SecondRazorPage.Model;

namespace SecondRazorPage.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }
<<<<<<< HEAD
        public DbSet<Category> Category { get; set; }//DbSet <Category> tells EF core to create a table using the file Category.cs; the word "category" outside is the name of that table, it can be a, b, c,...


=======
        public DbSet<Category> Category { get; set; }
        public DbSet<Teacher> Teachers { get; set; }  
>>>>>>> origin/thaikhang
        public DbSet<HocPhi> HocPhi { get; set; }
        public DbSet<BangDiem> BangDiem { get; set; }
        public DbSet<DiemRenLuyen> DiemRenLuyen { get; set; }
        public DbSet<HocBong> HocBong { get; set; }
        public DbSet<KyLuat> KyLuat { get; set; }
        public DbSet<ThoiKhoaBieu> ThoiKhoaBieu { get; set; }
        public DbSet<LichThi> LichThi { get; set; }
        public DbSet<KhenThuong> KhenThuong { get; set; }
<<<<<<< HEAD

        public DbSet<Teacher> Teachers { get; set; }  

=======
>>>>>>> origin/thaikhang
    }
}
