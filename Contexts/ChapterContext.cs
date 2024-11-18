using Microsoft.EntityFrameworkCore;
using Chapter.WebApi.Models;
using System.Data.SqlClient;
using Microsoft.Data.SqlClient;

namespace Chapter.WebApi.Contexts
{
    public class ChapterContext : DbContext
    {
        public ChapterContext()
        {

        }
        public ChapterContext(DbContextOptions<ChapterContext> options) : base(options)
        {
    
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if(!optionsBuilder.IsConfigured)
            {
                //string de conexao da máquina
                optionsBuilder.UseSqlServer("Server=localhost\\SQLEXP...;", "Database=Chapter;Trusted_Connection=True;");
            }
        }
    }
}