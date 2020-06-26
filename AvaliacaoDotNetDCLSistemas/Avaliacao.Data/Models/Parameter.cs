
namespace Avaliacao.Data.Models
{
    using System.ComponentModel.DataAnnotations;
    public class Parameter
    {
        public int Id { get; set; }

        [Display(Name = "Salario Fixo")]
        public double FixedSalary { get; set; }

        [Display(Name = "Comisão Fixa")]
        public double FixedCommission { get; set; }

        [Display(Name = "Taxa Base")]
        public double BaseRate { get; set; }

        [Display(Name = "Taxa Pos.")]
        public double SecondRate { get; set; }
        
    }
}
