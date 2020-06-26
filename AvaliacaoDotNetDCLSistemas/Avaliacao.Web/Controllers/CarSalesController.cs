namespace Avaliacao.Web.Controllers
{
    using Avaliacao.Core;
    using Avaliacao.Data.Data;
    using Avaliacao.Data.Models;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.EntityFrameworkCore;
    using System.Linq;
    using System.Security.Cryptography.X509Certificates;
    using System.Threading.Tasks;

    public class CarSalesController : Controller
    {
        private readonly DataContext _context;

        public CarSalesController(DataContext context)
        {
            _context = context;
        }

        // GET: CarSales
        public async Task<IActionResult> Index()
        {
            var list = await _context.Sales.ToListAsync();
            var parameter = _context.Parameters.FirstOrDefault();

            ViewBag.Salary = Calculation.Salary(list, parameter);
            return View(list);
        }

        // GET: CarSales/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            CarSale carSale = await _context.Sales
                .FirstOrDefaultAsync(m => m.Id == id);
            if (carSale == null)
            {
                return NotFound();
            }

            return View(carSale);
        }

        // GET: CarSales/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: CarSales/Create

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(CarSale carSale)
        {
            if (ModelState.IsValid)
            {
                _context.Add(carSale);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(carSale);
        }

        // GET: CarSales/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            CarSale carSale = await _context.Sales.FindAsync(id);
            if (carSale == null)
            {
                return NotFound();
            }
            return View(carSale);
        }

        // POST: CarSales/Edit/5

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, CarSale carSale)
        {
            if (id != carSale.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(carSale);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!CarSaleExists(carSale.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(carSale);
        }

        // GET: CarSales/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            CarSale carSale = await _context.Sales
                .FirstOrDefaultAsync(m => m.Id == id);
            if (carSale == null)
            {
                return NotFound();
            }

            return View(carSale);
        }

        // POST: CarSales/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            CarSale carSale = await _context.Sales.FindAsync(id);
            _context.Sales.Remove(carSale);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool CarSaleExists(int id)
        {
            return _context.Sales.Any(e => e.Id == id);
        }

        public IActionResult Clean()
        {
            var all = from c in _context.Sales select c;
            _context.Sales.RemoveRange(all);
            _context.SaveChanges();

            return RedirectToAction(nameof(Index));
        }
    }
}
