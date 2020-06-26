
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
        public static double Salary(List<CarSale> list, Parameter parameter)
        {
            double cash = 0;

            double fixedCommission = parameter.FixedCommission;
            double fixedSalary = parameter.FixedSalary;
            double percentage = 5 / 100;

            foreach (CarSale item in list)
            {
                cash = (item.Price * percentage) + fixedCommission;

            }

            return cash + fixedSalary;
        }

        /// <summary>
        /// Return the cost of the call.
        /// </summary>
        /// <param name="call">Data of the call</param>
        /// <returns></returns>
        public static double CallCost(Call call, Parameter parameter)
        {
            double pay = 0;

            double baseRate = parameter.BaseRate;
            double secondRate = parameter.SecondRate;

            double seconds = (call.End - call.Begin).TotalSeconds;

            if (seconds > 60)
            {
                seconds = seconds - 60;
                double frag = seconds / 6;

                pay = baseRate + (frag * secondRate);

            }
            else
            {
                pay = baseRate;
            }

            return pay;

        }

    }
}
