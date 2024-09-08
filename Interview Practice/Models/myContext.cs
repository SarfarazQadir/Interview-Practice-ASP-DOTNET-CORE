using Microsoft.EntityFrameworkCore;

namespace Interview_Practice.Models
{
    public class myContext : DbContext
    {
        public myContext(DbContextOptions options) : base(options)
        {

        }

        public DbSet<Student> tbl_student { get; set; }
    }
}
