
namespace Avaliacao.Core
{
    using Avaliacao.Data.Models;
    using System.Collections.Generic;

    public class Calculation
    {
        /// <summary>
        /// Return de final salary of salesman.
        /// </summary>
        /// <param name="list">SaleList</param>
        /// <returns></returns>
        public static double Salary(List<CarSale> list)
        {
            double cash = 0;

            double fixedCommission = 10;
            double fixedSalary = 1000;
            double percentage = 5/100;

            foreach (CarSale item in list)
            {
                cash = (item.Price * percentage) + fixedCommission;

            }

            return cash + fixedSalary;
        }
    }
}
