using Avaliacao.Data.Models;
using Microsoft.AspNetCore.Http.Connections;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading.Tasks;
using Avaliacao.Data.Data;

namespace Avaliacao.Web.Data
{
    public class SeedDb
    {
        private readonly Avaliacao.Data.Data.DataContext _context;

        public SeedDb(Avaliacao.Data.Data.DataContext context)
        {
            _context = context;
        }

        public async Task SeedAsync()
        {
            await _context.Database.EnsureCreatedAsync();
            await ParameterCheck();
        }

        private async Task ParameterCheck()
        {
            if (!_context.Parameters.Any())
            {
                var parameter = new Parameter()
                {
                    Id = 1,

                    FixedSalary = 1000,
                    FixedCommission = 10,

                    BaseRate = 0.10,
                    SecondRate = 0.01,

                };

                _context.Parameters.Add(parameter);
                await _context.SaveChangesAsync();
            }
        }
    }

}
