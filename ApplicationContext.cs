using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace SvoyaIgraEFCore
{
    public class ApplicationContext : DbContext
    {
        public DbSet<Question> Questions { get; set; } = null!;
        public ApplicationContext()
        {
            Database.EnsureCreated();   // создаем/подключаемся бд с новой схемой
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=QuestionsDB.db");
        }
    }

}
