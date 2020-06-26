using Avaliacao.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace Avaliacao.Data.Data
{
    public class DataContext : DbContext
    {

        public DataContext(DbContextOptions<DataContext> options)
             : base(options)
        {
        }

        public DbSet<CarSale> Sales { get; set; }

        public DbSet<Call> Calls { get; set; }

        public DbSet<Parameter> Parameters { get; set; }

    }
}
