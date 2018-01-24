using System.Data.Entity;
using TestIdentity.Models;

namespace TestIdentity.Data
{
    public class ApplicationDbContext : Models.ApplicationDbContext
    {
        public DbSet<PNCModel> PNC { get; set; }
    }
}