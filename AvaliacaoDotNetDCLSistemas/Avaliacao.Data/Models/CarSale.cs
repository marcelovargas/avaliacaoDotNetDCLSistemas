namespace Avaliacao.Data.Models
{
    using System.ComponentModel.DataAnnotations;
    public class CarSale
    {
        public int Id { get; set; }

        [Display(Name = "Preço")]
        public double Price { get; set; }
    }
}
