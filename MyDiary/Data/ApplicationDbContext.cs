using Microsoft.EntityFrameworkCore;
using MyDiary.Models;

namespace MyDiary.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext>options): base(options)
        {
            
        }

        public DbSet<DiaryEntry> DiaryEntries { get; set; }
    }
}
