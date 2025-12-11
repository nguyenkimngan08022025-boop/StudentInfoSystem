using Microsoft.EntityFrameworkCore;
using SecondRazorPage.Model;

namespace SecondRazorPage.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }
        public DbSet<Category> Category { get; set; }
        public DbSet<Teacher> Teachers { get; set; }  
        public DbSet<HocPhi> HocPhi { get; set; }
        public DbSet<BangDiem> BangDiem { get; set; }
        public DbSet<DiemRenLuyen> DiemRenLuyen { get; set; }
        public DbSet<HocBong> HocBong { get; set; }
        public DbSet<KyLuat> KyLuat { get; set; }
        public DbSet<ThoiKhoaBieu> ThoiKhoaBieu { get; set; }
        public DbSet<LichThi> LichThi { get; set; }
        public DbSet<KhenThuong> KhenThuong { get; set; }
    }
}
