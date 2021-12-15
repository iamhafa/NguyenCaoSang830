using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using NguyenCaoSang830.Models;
namespace NguyenCaoSang830.Data
{
    public class ApplicationDBContext : DbContext
    {
        public ApplicationDBContext (DbContextOptions<ApplicationDBContext> options)
            : base(options)
        {
        }
        public DbSet<NCS0830> NCS0830s { get; set;}
        public DbSet<NguyenCaoSang830.Models.UniversityNCS830> UniversityNCS830 { get; set; }
    }
}
    
