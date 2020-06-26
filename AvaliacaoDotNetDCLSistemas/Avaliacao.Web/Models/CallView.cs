namespace Avaliacao.Web.Models
{
    using Avaliacao.Data.Models;
    using System.ComponentModel.DataAnnotations;

    public class CallView : Call
    {
        [Display(Name = "Preço")]
        public double Price { get; set; }
    }
}
