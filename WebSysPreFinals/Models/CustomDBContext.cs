using Microsoft.EntityFrameworkCore;

namespace WebSysPreFinals.Models
{
    public partial class StudInfoSysContext
    {
        public StudInfoSysContext()
        {
            
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=DESKTOP-VVUU92F\\SQLEXPRESS;Initial Catalog=StudInfoSys;Integrated Security=True; Trust Server Certificate=True");
        }
    } 
}
