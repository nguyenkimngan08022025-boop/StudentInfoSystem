using Microsoft.EntityFrameworkCore;
using SecondRazorPage.Model;

namespace SecondRazorPage.Data
{
    public class ApplicationDbContext: DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }
        public DbSet<Category> Category { get; set; }//DbSet <Category> tells EF core to create a table using the file Category.cs; the word "category" outside is the name of that table, it can be a, b, c,...

    }
}
