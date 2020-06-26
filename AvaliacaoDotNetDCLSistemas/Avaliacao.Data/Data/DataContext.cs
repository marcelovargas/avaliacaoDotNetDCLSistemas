using Avaliacao.Data.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Avaliacao.Data.Data
{
    public class DataContext : DbContext
    {
        public DbSet<CarSale> Sales { get; set; }

        public DataContext(DbContextOptions<DataContext> options)
             : base(options)
        {
        }

    }
}
