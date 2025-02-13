using CsvImporterApi.Models;
using Microsoft.EntityFrameworkCore;

namespace CsvImporterApi.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

        public DbSet<Record> Records { get; set; }
    }
}
