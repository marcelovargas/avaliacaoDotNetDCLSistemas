using System;
using System.Collections.Generic;
using System.Text;

namespace Avaliacao.Data.Models
{
    public class Parameter
    {
        public int Id { get; set; }

        public double FixedSalary { get; set; }
        public double FixedCommission { get; set; }
        public double BaseRate { get; set; }
        public double SecondRate { get; set; }
        
    }
}
